namespace MyProject;

public static class FhirHelper
{
    public static long GetVersionNumber(string url)
    {
        return Convert.ToInt64(url.Substring(url.LastIndexOf("-")+1));
    }
}