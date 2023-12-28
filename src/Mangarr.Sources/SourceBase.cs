using Mangarr.Sources.Clients;

namespace Mangarr.Sources;

internal abstract partial class SourceBase : ISource
{
    protected const string USER_AGENT =
        "Mozilla/5.0 (Linux; Android 6.0; Nexus 5 Build/MRA58N) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Mobile Safari/537.36";

    private readonly GenericHttpClient _genericHttpClient;
    private readonly CloudflareHttpClient _cloudflareHttpClient;

    protected SourceBase(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
    {
        _genericHttpClient = genericHttpClient;
        _genericHttpClient.AddHeader("Referer", Url);
        _genericHttpClient.AddHeader("User-Agent", USER_AGENT);

        _cloudflareHttpClient = cloudflareHttpClient;
        _cloudflareHttpClient.AddHeader("Referer", Url);
        _cloudflareHttpClient.AddHeader("User-Agent", USER_AGENT);
    }

    protected virtual bool HasCloudflareProtection => false;

    protected CustomHttpClient GetHttpClient() => HasCloudflareProtection ? _cloudflareHttpClient : _genericHttpClient;
}
