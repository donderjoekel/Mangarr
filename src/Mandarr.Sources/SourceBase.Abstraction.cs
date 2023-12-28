using FluentResults;
using Mandarr.Sources.Models.Chapter;
using Mandarr.Sources.Models.Manga;
using Mandarr.Sources.Models.Page;
using Mandarr.Sources.Models.Search;

namespace Mandarr.Sources;

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
