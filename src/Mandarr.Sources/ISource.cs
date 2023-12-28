using FluentResults;
using Mandarr.Sources.Models.Chapter;
using Mandarr.Sources.Models.Page;
using Mandarr.Sources.Models.Search;

namespace Mandarr.Sources;

public interface ISource
{
    string Identifier { get; }
    string Name { get; }
    string Url { get; }

    // Task<Result<MangaDirectory>> GetDirectory();
    Task<Result<SearchResult>> Search(string query);
    Task<Result<ChapterList>> GetChapterList(string mangaId);
    Task<Result<PageList>> GetPageList(string chapterId);
    Task<Result<byte[]>> GetImage(string pageId);
}
