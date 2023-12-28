using Injectio.Attributes;
using Mangarr.Sources.Clients;

namespace Mangarr.Sources.Sources.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class KnightNoScanlationSource : MadaraSourceBase
{
    protected override string Id => "knightnoscanlation";
    protected override string Name => "Knight No Scanlation";
    protected override string Url => "https://knightnoscanlation.com";

    public KnightNoScanlationSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
