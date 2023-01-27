using System.Text;

using Colorify;
using Colorify.UI;

using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;

using Task = System.Threading.Tasks.Task;

namespace MyProject;

class Program
{
    private const string _fhirServerUri = "https://psims-uat.azure-api.net";
    private const string _subKey = "d646e7c4cf7f4ffca1ca98fa11e1789e";

    private static Format _colorify = new Format(Theme.Dark);
    private static FhirService _fhirService = new FhirService(_fhirServerUri, _subKey);

    //static FhirService _fhirService;
    private static StringBuilder _sbAdverseEvent;
    private static StringBuilder _sbCodeSystems;
    private static Dictionary<string, CodeSystemDTO> _codeSystems;

    public class CodeSystemDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Table { get; set; }
    }

    public static async Task Main(string[] args)
    {
        var cs = await _fhirService.GetCapabilityStatementAsync();

        // get the profiles
        foreach(var adverseEvent in cs.Rest[0].Resource.Where(x => x.Type == ResourceType.AdverseEvent))
        {
            _sbAdverseEvent = new();
            _sbCodeSystems = new();
            _codeSystems = new();

            //var adverseEvent = cs.Rest[0].Resource.OrderByDescending(x => x.Profile?.Reference).Where(x => x.Type == ResourceType.AdverseEvent).First();
            var profileUri = adverseEvent.Profile?.Reference;
            _colorify.WriteLine($"{adverseEvent.Type} - Path: {profileUri}", Colors.bgSuccess);

            var version = GetVersion(profileUri);
            _colorify.WriteLine($"{adverseEvent.Type} - Version: v{version}", Colors.bgSuccess);

            _sbAdverseEvent.AppendLine($"Taxonomy document for {adverseEvent.Type} v{version}");
            _sbAdverseEvent.AppendLine($"");

            // write out the code systems
            _sbCodeSystems.AppendLine($"Code system document for {adverseEvent.Type} v{version}");
            _sbCodeSystems.AppendLine($"");

            // load this profile and start to interate
            await ProcessProfileAsync(profileUri);           

            // write out the code systems
            foreach (var codeSystem in _codeSystems)
            {
                // write the default values into the main code-system doc
                _sbCodeSystems.AppendLine($"## {codeSystem.Value.Name}");
                _sbCodeSystems.AppendLine($"");
                _sbCodeSystems.AppendLine($"- Id: {codeSystem.Value.Id}");
                _sbCodeSystems.AppendLine($"");
                _sbCodeSystems.AppendLine($"- Count: {codeSystem.Value.Table.Split("\n").Length - 10}");
                _sbCodeSystems.AppendLine($"");

                // if the list is too long then split to an alternate page, and create a link 
                if (codeSystem.Value.Table.Split("\n").Length > 35)
                {
                    var sbLongCodeSystem = new StringBuilder();
                    sbLongCodeSystem.AppendLine($"# {codeSystem.Value.Name}");
                    sbLongCodeSystem.AppendLine($"");
                    sbLongCodeSystem.AppendLine($"This code system has a lot of items, so has been extracted to its own page. The grouped record is [here](../../code-systems#{GetPathAnchor(codeSystem.Value.Name)}).");
                    sbLongCodeSystem.AppendLine($"");
                    sbLongCodeSystem.AppendLine(codeSystem.Value.Table);
                    sbLongCodeSystem.AppendLine($"");

                    Directory.CreateDirectory($"D:\\dev\\fhir\\firely-test\\.mkdocs\\docs\\v{version}\\code-systems");
                    File.WriteAllText($"D:\\dev\\fhir\\firely-test\\.mkdocs\\docs\\v{version}\\code-systems\\{GetPathAnchor(codeSystem.Value.Name)}.md", sbLongCodeSystem.ToString());

                    _sbCodeSystems.AppendLine(CreateAdmonition("info", $"For the full list go to [{codeSystem.Key}](../code-systems/{GetPathAnchor(codeSystem.Value.Name)})", $"Too many codes to display"));
                    _sbCodeSystems.AppendLine($"");
                }
                else // write the table to this page
                {
                    _sbCodeSystems.AppendLine(codeSystem.Value.Table);
                    _sbCodeSystems.AppendLine($"");
                }
            }

            // Fetch the structure definition
            //await ProcessStructureDefinitionsAsync(resource.Profile.Reference);

            Directory.CreateDirectory($"D:\\dev\\fhir\\firely-test\\.mkdocs\\docs\\v{version}");
            File.WriteAllText($"D:\\dev\\fhir\\firely-test\\.mkdocs\\docs\\v{version}\\taxonomy.md", _sbAdverseEvent.ToString());
            File.WriteAllText($"D:\\dev\\fhir\\firely-test\\.mkdocs\\docs\\v{version}\\code-systems.md", _sbCodeSystems.ToString());

        }
        _colorify.ResetColor();
    }

    static async Task ProcessProfileAsync(string profileUri, int count = 2)
    {
        try
        {
            StructureDefinition profile = null;
            if (profileUri.ToLower().Contains("hl7"))
            {
                _colorify.WriteLine($"{new String(' ', count)} - {profileUri}", Colors.txtInfo);
                _sbAdverseEvent.AppendLine($"- Profile URI not loaded: {profileUri}");
                _sbAdverseEvent.AppendLine($"");
                profile = (StructureDefinition)(await _fhirService.GetFhirResourceAsync(profileUri));
            } 
            else
            {
                profile = (StructureDefinition)(await _fhirService.GetTaxonomyResourceAsync(profileUri));
            }


            _colorify.WriteLine($"{new String(' ', count)}  - {profile.Description}");
            _colorify.WriteLine($"{new String(' ', count)}  - {profile.Id}");

            _sbAdverseEvent.AppendLine($"Desc: {profile.Description}");
            _sbAdverseEvent.AppendLine($"");

            _sbAdverseEvent.AppendLine($"- Id: {profile.Id}");
            _sbAdverseEvent.AppendLine($"");

            _sbAdverseEvent.AppendLine($"- Url: [{profileUri}]({profileUri})");
            _sbAdverseEvent.AppendLine($"");

            foreach (var profileElement in profile.Snapshot.Element)
            {
                var elementId = profileElement.ElementId;
                var typeName = profileElement.TypeName;
                var sliceName = profileElement.SliceName;
                var definition = profileElement.Definition;
                var cardMin = profileElement.Min?.ToString() ?? "null";
                var cardMax = profileElement.Max?.ToString() ?? "null";
                var nestedTypes = profileElement.Type;
                var bindingValueSets = profileElement.Binding?.ValueSet;

                // add unique slice names to a list
                if (sliceName != null)
                {
                    // display the slice name
                    if (!string.IsNullOrWhiteSpace(sliceName))
                    {
                        _colorify.WriteLine($"{new String(' ', count)} - {sliceName}", Colors.txtDefault);
                        _sbAdverseEvent.AppendLine($"{new String('#', count)} {sliceName}");
                        _sbAdverseEvent.AppendLine($"");
                    }

                    // display the definition if it isn't the same as slice name or the default extension explanation
                    if (elementId.EndsWith(sliceName) && definition != null && !definition.StartsWith("May be used to represent additional"))
                    {
                        _colorify.WriteLine($"{new String(' ', count)}  - {definition}", Colors.txtPrimary);
                        _sbAdverseEvent.AppendLine($" Definition: {definition}");
                        _sbAdverseEvent.AppendLine($"");
                    }

                    if (!string.IsNullOrEmpty(cardMin) || !string.IsNullOrEmpty(cardMin))
                    {
                        _colorify.WriteLine($"{new String(' ', count)}  - Cardinality: {cardMin}", Colors.txtMuted);
                        _sbAdverseEvent.AppendLine($"- Cardinality");
                        _sbAdverseEvent.AppendLine($"");

                        if (!string.IsNullOrEmpty(cardMin))
                        {
                            _colorify.WriteLine($"{new String(' ', count)}    - Min: {cardMin}", Colors.txtMuted);
                            _sbAdverseEvent.AppendLine($"    - Min: {cardMin}");
                            _sbAdverseEvent.AppendLine($"");
                        }

                        if (!string.IsNullOrEmpty(cardMax))
                        {
                            _colorify.WriteLine($"{new String(' ', count)}    - Max: {cardMax}", Colors.txtMuted);
                            _sbAdverseEvent.AppendLine($"    - Max: {cardMax}");
                            _sbAdverseEvent.AppendLine($"");
                        }
                    }
                }
                else
                {
                    _colorify.WriteLine($"{new String(' ', count)}  - {profileElement.ElementId}", Colors.txtMuted);
                }

                if (elementId.Contains(".value"))
                {
                    var valueType = $"- Type: `{elementId.Substring(elementId.LastIndexOf('.') + 1, elementId.Length - elementId.LastIndexOf('.') - 1).Replace("value", "")}`";
                    _colorify.WriteLine($"{new String(' ', count)}  {valueType}", Colors.txtWarning);
                    _sbAdverseEvent.AppendLine(valueType);
                    _sbAdverseEvent.AppendLine($"");
                }

                // if the definition has nested types
                foreach (var nestedType in nestedTypes)
                {
                    if (nestedType.Profile != null)
                    {
                        _colorify.WriteLine($"{new String(' ', count)}  - Nested profile    : {nestedType.Profile}", Colors.txtInfo);
                        _sbAdverseEvent.AppendLine($"Nested profile: [{nestedType.Profile}]({nestedType.Profile}) `{nestedType.Code}`");
                        _sbAdverseEvent.AppendLine($"");
                        await ProcessProfileAsync(nestedType.Profile, count + 1);
                    }
                    else if (nestedType.TargetProfile != null)
                    {
                        _colorify.WriteLine($"{new String(' ', count)}  - Nested target profile    : {nestedType.TargetProfile}", Colors.txtPrimary);
                        _sbAdverseEvent.AppendLine($"Target profile: [{nestedType.TargetProfile}]({nestedType.Profile})");
                        _sbAdverseEvent.AppendLine($"{nestedType.Code}");
                        _sbAdverseEvent.AppendLine($"");
                        await ProcessProfileAsync(nestedType.TargetProfile, count + 1);

                    }
                }

                // if the definition is a valueCode then get the allowable entries
                if (elementId.EndsWith("valueCode") && bindingValueSets != null)
                {
                    foreach (var valueSet in bindingValueSets)
                    {
                        _colorify.WriteLine($"{new String(' ', count)}  - Value set: {valueSet.Value}", Colors.txtInfo);
                        _sbAdverseEvent.AppendLine($"- Value set Url: [{valueSet.Value}]({valueSet.Value})");
                        _sbAdverseEvent.AppendLine($"");
                        await ProcessValueSetAsync(valueSet.Value?.ToString(), count + 1);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            _colorify.WriteLine($"{new String(' ', count)}  - Error: {ex.Message}", Colors.txtDanger);
            _sbAdverseEvent.AppendLine(CreateErrorAdmonition("An error occurred, details as follows: ", ex.Message, "Error occurred processing profile"));
        }
    }

    static async Task ProcessValueSetAsync(string profileUri, int count = 0)
    {
        ValueSet profile = (ValueSet)(await _fhirService.GetTaxonomyResourceAsync(profileUri));
        _colorify.WriteLine($"{new String(' ', count)} - {profile.Description}", Colors.txtSuccess);

        var version = GetVersion(profileUri);

        _sbAdverseEvent.AppendLine($"The code system options for [{profile.Description}](../code-systems/#{GetPathAnchor(profile.Description.ToString())}) are: ");
        _sbAdverseEvent.AppendLine($"");

        var sbCodeSystem = new StringBuilder();

        sbCodeSystem.AppendLine($"## {profile.Name}");
        if (profile.Name.ToString() != profile.Description.ToString())
        {
            sbCodeSystem.AppendLine($" {profile.Description}");
        }
        sbCodeSystem.AppendLine($"");

        foreach (var include in profile.Compose.Include)
        {
            _colorify.WriteLine($"{new String(' ', count)}  - {include.System}", Colors.txtSuccess);
            sbCodeSystem.AppendLine($"[{include.System}]({include.System})");
            sbCodeSystem.AppendLine($"");
            
            var codeSystem = await ProcessCodeSystemAsync(include.System, count);
            sbCodeSystem.AppendLine(codeSystem.Value.Table);

            if (!_codeSystems.ContainsKey(profile.Id))
            {
                _codeSystems.Add(profile.Id, codeSystem.Value);
            }
        }
    }

    static async Task<KeyValuePair<string, CodeSystemDTO>> ProcessCodeSystemAsync(string profileUri, int count = 0)
    {

        CodeSystem profile = null;
        if (profileUri.Contains("HL7"))
        {
            profile = (CodeSystem)(await _fhirService.GetFhirResourceAsync(profileUri));
        }
        else
        {
            profile = (CodeSystem)(await _fhirService.GetTaxonomyResourceAsync(profileUri));
        }

        var version = GetVersion(profileUri);

        var sbCodeSystem = new StringBuilder();

        //sbCodeSystem.AppendLine($"- Id : {profile.Id} ");
        //sbCodeSystem.AppendLine($"- Count : {profile.Count} ");
        sbCodeSystem.AppendLine($"");

        // build the code system table, so it can be used on both taxonomy and code system pages
        var sbTable = new StringBuilder();
        sbTable.AppendLine($" | Code | Display |");
        sbTable.AppendLine($" | --- | --- |");

        var sbShortTable = new StringBuilder();
        sbShortTable.AppendLine($" | Code | Display |");
        sbShortTable.AppendLine($" | --- | --- |");

        var codeCounter = 0;
        foreach (var concept in profile.Concept)
        {
            if (codeCounter < 10)
            {
                _colorify.WriteLine($"{new String(' ', count)}   - {concept.Code,3}: {concept.Display}", Colors.txtSuccess);
                sbShortTable.AppendLine($"| `{concept.Code,3}` | {concept.Display} |");
            } else if (codeCounter == 10)
            {
                _colorify.WriteLine($"{new String(' ', count)}   - ... additional lines hidden for brevity", Colors.txtWarning);
                sbShortTable.AppendLine($"| ... | ... |");
                sbShortTable.AppendLine($"");
                sbShortTable.AppendLine(CreateAdmonition("info", $"For full list go to [{profile.Id}](../code-systems/{GetPathAnchor(profile.Description.ToString())})", $"Displaying 10 of {profile.Count}"));
                sbShortTable.AppendLine($"");
            }

            sbTable.AppendLine($"| `{concept.Code,3}` | {concept.Display} |");

            codeCounter++;
        }

        _sbAdverseEvent.AppendLine(sbShortTable.ToString());
        sbCodeSystem.AppendLine(sbTable.ToString());

        var csDTO = new CodeSystemDTO() { Id = profile.Id, Name = profile.Description.ToString(), Table = sbCodeSystem.ToString(), Url = profileUri };

        return new KeyValuePair<string, CodeSystemDTO>(profile.Id, csDTO);
    }


    private static string CreateAdmonition(string type, string content, string header = "")
    {
        var sb = new StringBuilder();
        sb.AppendLine($"!!! {type} \"{header}\"");
        sb.AppendLine($"");

        var splitLines = content.Split("\n");

        foreach (var line in splitLines)
        {
            sb.AppendLine($"    {line}");
            sb.AppendLine($"");
        }

        return sb.ToString();
    }

    private static string CreateErrorAdmonition(string content, string exMessage, string header = "")
    {
        var sb = new StringBuilder();
        sb.AppendLine($"!!! failure \"{header}\"");
        sb.AppendLine($"");

        var splitLines = content.Split("\n");

        foreach (var line in splitLines)
        {
            sb.AppendLine($"    {line}");
            sb.AppendLine($"");
        }

        var splitMessage = exMessage.Split("\n");

        foreach (var msg in splitMessage)
        {
            sb.AppendLine($"    > {msg}");
            sb.AppendLine($"");
        }

        sb.AppendLine($"");

        return sb.ToString();
    }

    private static int GetVersion(string uri)
    {
        return  Convert.ToInt32(uri.Substring(uri.LastIndexOf('-') + 1));
    }

    public  static string GetPathAnchor(string id)
    {
        return id.ToLower().Replace(' ', '-');
    }

}


public class FhirService
{
    private readonly string _baseUrl;
    private readonly string _subKey;
    private SubscriptionKeyHeaderHandler _handler;

    //private FhirClientSettings _fhirClientSettings = new FhirClientSettings()
    //    {
    //        PreferredFormat = ResourceFormat.Json,
    //        PreferredReturn = Prefer.ReturnRepresentation,
    //        VerifyFhirVersion = true,
    //    };

    private string _hl7ApiUri => $"https://hl7.org/fhir";
    private string _adverseEventApiUri => $"{_baseUrl}/adverse-event/fhir";
    private string _taxonomyApiUri => $"{_baseUrl}/taxonomy/fhir";

    public FhirService(string baseUrl, string subKey)
    {
        this._baseUrl = baseUrl;
        this._subKey = subKey;

        this._handler = new SubscriptionKeyHeaderHandler(_subKey);
    }

    /// <summary>
    /// Fetch the CapabilityStatement.
    /// </summary>
    /// <param name="uri">Use the supplied uri if it exists, or default to the adverse event API. </param>
    /// <returns></returns>
    public async Task<CapabilityStatement> GetCapabilityStatementAsync(string? uri = null)
    {
        var fhirClient = new FhirClient(uri ?? _adverseEventApiUri, FhirClientSettings.CreateDefault(), _handler);
        return await fhirClient.CapabilityStatementAsync();
    }

    public async Task<Resource> GetTaxonomyResourceAsync(string uri)
    {
        var fhirClient = new FhirClient(_taxonomyApiUri, FhirClientSettings.CreateDefault(), _handler);
        return await fhirClient.ReadAsync<Resource>(uri);
    }

    public async Task<Resource> GetFhirResourceAsync(string uri)
    {
        var fhirClient = new FhirClient(_hl7ApiUri, FhirClientSettings.CreateDefault());
        return await fhirClient.ReadAsync<Resource>(uri);
    }

    ////public IEnumerable<ResourceComponent> GetResources(CapabilityStatement cs, ResourceType resourceType = ResourceType.AdverseEvent)
    ////{
    ////    return cs.Rest.SelectMany(x => x.Resource).Where(x => x.Type == resourceType);
    ////}

    ////public async Task<StructureDefinition> GetStructureDefinitionsAsync(string resourcePath)
    ////{
    ////    var json = await GetJsonAsync(resourcePath);
    ////    return JsonConvert.DeserializeObject<StructureDefinition>(json)!;
    ////}

    ////public async Task<string> GetJsonAsync(string url)
    ////{
    ////    using (var httpClient = new HttpClient(_handler))
    ////    {
    ////        return await httpClient.GetStringAsync(url);
    ////    }
    ////}

}

////public class MyFhirCapabilityStatement
////{
////    public string Status { get; set; }
////    public DateTime Date { get; set; }
////    public string FhirVersion { get; set; }

////    public IEnumerable<MyFhirRest> Rest { get; set; }
////}

////public class MyFhirRest
////{
////    public string Mode { get; set; }
////    public IEnumerable<MyFhirResource> Resource { get; set; }
////}

////public class MyFhirResource
////{
////    public ResourceType Type { get; set; }
////    public MyFhirProfile Profile { get; set; }
////}

////public class MyFhirProfile
////{
////    /// <summary>
////    /// The URL of the profile resource
////    /// </summary>
////    public string Reference { get; set; }

////    public long Version => FhirHelper.GetVersionNumber(Reference);
////}

//////public class MyFhirStructureDefinition
//////{
//////    public string Url { get; set; }
//////    public  string Version { get; set; }
//////    public string Name { get; set; }
//////    public string Title { get; set; }
//////    public string Description { get; set; }
//////    public ResourceType ResourceType { get; set; }
//////    public string Type { get; set; }
//////    public MyFhirDifferential Differential { get; set; }
//////}

////public class MyFhirDifferential
////{
////    public IEnumerable<Element> Element { get; set; }
////}

////public class MyFhirElement
////{
////    public string Id { get; set; }
////    public string path { get; set; }
////    public string Short { get; set; }
////    public string Definition { get; set; }
////    public long Min { get; set; }
////    public string Max { get; set; }
////    public IEnumerable<MyFhirType> Type { get; set; }
////}

////public class MyFhirType
////{
////    public ResourceType Type { get; set; }
////    public string Profile { get; set; }
////    public string TargetProfile { get; set; }
////    public FHIRDefinedType Code { get; set; }
////}

//public enum MyFhirResourceType
//{
//    AdverseEvent,
//    Extension,
//    StructureDefinition
//}

//public enum MyFhirTypeCode
//{
//    Address,
//    Age,
//    Annotation,
//    Attachment,
//    BackboneElement,
//    Base64Binary,
//    Boolean,
//    Code,
//    CodeableConcept,
//    Coding,
//    ContactPoint,
//    Date,
//    DateTime,
//    Decimal,
//    Extension,
//    Id,
//    Identifier,
//    Instant,
//    Integer,
//    Markdown,
//    Meta,
//    Narrative,
//    Oid,
//    PositiveInt,
//    Reference,
//    Resource,
//    String,
//    Time,
//    UnsignedInt,
//    Uri
//}
