using FluentResults;
using Mangarr.Backend.Sources.Models.Chapter;
using Mangarr.Backend.Sources.Models.Page;
using Mangarr.Backend.Sources.Models.Search;

namespace Mangarr.Backend.Sources;

internal abstract partial class SourceBase
{
    protected abstract string Id { get; }
    protected abstract string Name { get; }
    protected abstract string Url { get; }
    protected abstract Task Initialize();
    protected abstract Task<Result> Cache();
    protected abstract Task<Result<string>> Status();
    protected abstract Task<Result<SearchResult>> Search(string query);
    protected abstract Task<Result<ChapterList>> GetChapterList(string mangaId);
    protected abstract Task<Result<PageList>> GetPageList(string chapterId);
    protected abstract Task<Result<byte[]>> GetImage(string pageId);
}
