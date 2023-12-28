using Injectio.Attributes;
using Mandarr.Sources.Clients;

namespace Mandarr.Sources.Sources.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ManhwaTopSource : MadaraSourceBase
{
    protected override string Id => "manhwatop";
    protected override string Name => "Manhwa Top";
    protected override string Url => "https://manhwatop.com";
    protected override bool UseIdChapterListMethod => true;

    public ManhwaTopSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
