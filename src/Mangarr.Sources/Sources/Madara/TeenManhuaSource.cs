using Injectio.Attributes;
using Mangarr.Sources.Clients;

namespace Mangarr.Sources.Sources.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class TeenManhuaSource : MadaraSourceBase
{
    protected override string Id => "teenmanhua";
    protected override string Name => "Teen Manhua";
    protected override string Url => "https://teenmanhua.io";

    public TeenManhuaSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
