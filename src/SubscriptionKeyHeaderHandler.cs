namespace MyProject;

public class SubscriptionKeyHeaderHandler : HttpClientHandler//ConsoleLoggingHandler
{
    private readonly string subKey;

    public SubscriptionKeyHeaderHandler(string subKey): base()
    {
        this.subKey = subKey;
    }

    protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        request.Headers.Add("Ocp-Apim-Subscription-Key", subKey);
        request.Headers.Add("Cache-Control", "no-cache");
        return await base.SendAsync(request, cancellationToken);
    }
}
