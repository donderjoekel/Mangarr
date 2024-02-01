using FluentResults;
using Mangarr.Stack.Sources.Models.Chapter;
using Mangarr.Stack.Sources.Models.Page;
using Mangarr.Stack.Sources.Models.Search;

namespace Mangarr.Stack.Sources;

public interface ISource
{
    string Identifier { get; }
    string Name { get; }
    string Url { get; }

    Task<Result> Initialize();
    Task<Result> Cache();
    Task<Result<string>> Status();
    Task<Result<SearchResult>> Search(string query, CancellationToken ct = default);
    Task<Result<ChapterList>> GetChapterList(string mangaId, CancellationToken ct = default);
    Task<Result<PageList>> GetPageList(string chapterId, CancellationToken ct = default);
    Task<Result<byte[]>> GetImage(string pageId, CancellationToken ct = default);
}
