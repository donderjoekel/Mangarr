using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ReaperDashScansSource : MangaStreamSourceBase
{
    protected override string Id => "reaper-scans";
    protected override string Name => "Reaper-Scans";
    protected override string Url => "https://reaper-scans.com";

    public ReaperDashScansSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
