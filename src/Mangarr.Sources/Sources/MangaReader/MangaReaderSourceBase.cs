using FluentResults;
using Mangarr.Sources.Clients;
using Mangarr.Sources.Models.Chapter;
using Mangarr.Sources.Models.Page;
using Mangarr.Sources.Models.Search;

namespace Mangarr.Sources.Sources.MangaReader;

internal abstract class MangaReaderSourceBase : SourceBase
{
    protected MangaReaderSourceBase(GenericHttpClient genericHttpClient, CloudflareHttpClient cloudflareHttpClient)
        : base(genericHttpClient, cloudflareHttpClient)
    {
    }

    protected override Task<Result<SearchResult>> Search(string query) => throw new NotImplementedException();

    protected override Task<Result<ChapterList>> GetChapterList(string mangaId) => throw new NotImplementedException();

    protected override Task<Result<PageList>> GetPageList(string chapterId) => throw new NotImplementedException();

    protected override Task<Result<byte[]>> GetImage(string pageId) => throw new NotImplementedException();
}
