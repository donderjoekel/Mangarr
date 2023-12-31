using FluentResults;
using Mangarr.Backend.Sources.Models.Chapter;
using Mangarr.Backend.Sources.Models.Page;
using Mangarr.Backend.Sources.Models.Search;

namespace Mangarr.Backend.Sources;

internal abstract partial class SourceBase
{
    string ISource.Identifier => Id;
    string ISource.Name => Name;
    string ISource.Url => Url;

    Task ISource.Initialize()
    {
        try
        {
            return Initialize();
        }
        catch (Exception e)
        {
            return Task.FromException(e);
        }
    }

    Task<Result> ISource.Cache()
    {
        try
        {
            return Cache();
        }
        catch (Exception e)
        {
            return Task.FromResult(Result.Fail(new ExceptionalError(e)));
        }
    }

    Task<Result<string>> ISource.Status()
    {
        try
        {
            return Status();
        }
        catch (Exception e)
        {
            return Task.FromResult(Result.Fail<string>(new ExceptionalError(e)));
        }
    }

    Task<Result<SearchResult>> ISource.Search(string query)
    {
        try
        {
            return Search(query);
        }
        catch (Exception e)
        {
            return Task.FromResult(Result.Fail<SearchResult>(new ExceptionalError(e)));
        }
    }

    Task<Result<ChapterList>> ISource.GetChapterList(string mangaId)
    {
        try
        {
            return GetChapterList(mangaId);
        }
        catch (Exception e)
        {
            return Task.FromResult(Result.Fail<ChapterList>(new ExceptionalError(e)));
        }
    }

    Task<Result<PageList>> ISource.GetPageList(string chapterId)
    {
        try
        {
            return GetPageList(chapterId);
        }
        catch (Exception e)
        {
            return Task.FromResult(Result.Fail<PageList>(new ExceptionalError(e)));
        }
    }

    Task<Result<byte[]>> ISource.GetImage(string pageId)
    {
        try
        {
            return GetImage(pageId);
        }
        catch (Exception e)
        {
            return Task.FromResult(Result.Fail<byte[]>(new ExceptionalError(e)));
        }
    }
}
