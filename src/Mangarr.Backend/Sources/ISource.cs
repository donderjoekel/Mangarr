using FluentResults;
using Mangarr.Backend.Sources.Models.Chapter;
using Mangarr.Backend.Sources.Models.Page;
using Mangarr.Backend.Sources.Models.Search;

namespace Mangarr.Backend.Sources;

public interface ISource
{
    string Identifier { get; }
    string Name { get; }
    string Url { get; }

    Task<Result> Initialize();
    Task<Result> Cache();
    Task<Result<string>> Status();
    Task<Result<SearchResult>> Search(string query);
    Task<Result<ChapterList>> GetChapterList(string mangaId);
    Task<Result<PageList>> GetPageList(string chapterId);
    Task<Result<byte[]>> GetImage(string pageId);
}
