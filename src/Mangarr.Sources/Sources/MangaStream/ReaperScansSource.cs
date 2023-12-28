using Injectio.Attributes;
using Mangarr.Sources.Clients;

namespace Mangarr.Sources.Sources.MangaStream;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ReaperScansSource : MangaStreamSourceBase
{
    protected override string Id => "reaperscans";
    protected override string Name => "Reaper Scans";
    protected override string Url => "https://reaper-scans.com";

    public ReaperScansSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
