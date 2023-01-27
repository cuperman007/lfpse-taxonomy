using Colorify;
using Colorify.UI;

namespace MyProject;

public class ConsoleLoggingHandler : HttpClientHandler
{
    public static Format _colorify { get; set; }

    public ConsoleLoggingHandler()
    {
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        _colorify = new Format(Theme.Dark);
        _colorify.WriteLine("Request: " + request, Colors.txtMuted);
        try
        {
            // base.SendAsync calls the inner handler
            var response = await base.SendAsync(request, cancellationToken);
            _colorify.WriteLine("Response: " + response, Colors.txtMuted);
            return response;
        }
        catch (Exception ex)
        {
            _colorify.WriteLine("Failed to get response: " + ex, Colors.bgDanger);
            throw;
        }
    }
}