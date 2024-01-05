// Auto generated

using Injectio.Attributes;
using Mangarr.Backend.Sources.Clients;

namespace Mangarr.Backend.Sources.Implementations.Madara;

[RegisterSingleton<ISource>(Duplicate = DuplicateStrategy.Append)]
internal class ReadManhuaSource : MadaraSourceBase
{
    protected override string Id => "readmanhua";
    protected override string Name => "ReadManhua";
    protected override string Url => "https://readmanhua.net";
    protected override bool HasCloudflareProtection => false;
    protected override bool UseAjaxChapterListMethod => false;
    protected override bool UseIdChapterListMethod => true;

    public ReadManhuaSource(
        GenericHttpClient genericHttpClient,
        CloudflareHttpClient cloudflareHttpClient,
        ILoggerFactory loggerFactory
    )
        : base(genericHttpClient, cloudflareHttpClient, loggerFactory)
    {
    }
}
