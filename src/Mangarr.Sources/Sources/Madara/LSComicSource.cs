using Injectio.Attributes;
using Mangarr.Sources.Clients;

namespace Mangarr.Sources.Sources.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class LSComicSource : MadaraSourceBase
{
    protected override string Id => "lscomic";
    protected override string Name => "LS Comic";
    protected override string Url => "https://lscomic.com";

    protected override bool UseAjaxChapterListMethod => true;

    public LSComicSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
