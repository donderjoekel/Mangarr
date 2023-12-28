﻿using Injectio.Attributes;
using Mandarr.Sources.Clients;

namespace Mandarr.Sources.Sources.Madara;

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
