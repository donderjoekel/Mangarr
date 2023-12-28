using FluentResults;
using Mangarr.Sources.Models.Chapter;
using Mangarr.Sources.Models.Manga;
using Mangarr.Sources.Models.Page;
using Mangarr.Sources.Models.Search;

namespace Mangarr.Sources;

internal abstract partial class SourceBase
{
    protected abstract string Id { get; }
    protected abstract string Name { get; }
    protected abstract string Url { get; }
    protected abstract Task<Result<SearchResult>> Search(string query);
    protected abstract Task<Result<ChapterList>> GetChapterList(string mangaId);
    protected abstract Task<Result<PageList>> GetPageList(string chapterId);
    protected abstract Task<Result<byte[]>> GetImage(string pageId);
}
