using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class MangaBobSource : MadaraSourceBase
{
    protected override string Id => "mangabob";
    protected override string Name => "Manga Bob";
    protected override string Url => "https://mangabob.com";
    protected override bool UseAjaxChapterListMethod => true;

    public MangaBobSource(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }
}
