using FluentResults;
using Mangarr.Stack.Sources.Models.Chapter;
using Mangarr.Stack.Sources.Models.Page;
using Mangarr.Stack.Sources.Models.Search;

namespace Mangarr.Stack.Sources;

internal abstract partial class SourceBase
{
    protected abstract string Id { get; }
    protected abstract string Name { get; }
    protected abstract string Url { get; }
    protected abstract Task<Result> Initialize();
    protected abstract Task<Result> Cache();
    protected abstract Task<Result<string>> Status();
    protected abstract Task<Result<SearchResult>> Search(string query, CancellationToken ct);
    protected abstract Task<Result<ChapterList>> GetChapterList(string mangaId, CancellationToken ct);
    protected abstract Task<Result<PageList>> GetPageList(string chapterId, CancellationToken ct);
    protected abstract Task<Result<byte[]>> GetImage(string pageId, CancellationToken ct);
}
