using FluentResults;
using Mangarr.Stack.Sources.Models.Chapter;
using Mangarr.Stack.Sources.Models.Page;
using Mangarr.Stack.Sources.Models.Search;

namespace Mangarr.Stack.Sources;

internal abstract partial class SourceBase
{
    string ISource.Identifier => Id;
    string ISource.Name => Name;
    string ISource.Url => Url;

    Task<Result> ISource.Initialize()
    {
        try
        {
            return Initialize();
        }
        catch (Exception e)
        {
            return Task.FromResult(Result.Fail(new ExceptionalError(e)));
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

    Task<Result<SearchResult>> ISource.Search(string query, CancellationToken ct)
    {
        try
        {
            return Search(query, ct);
        }
        catch (Exception e)
        {
            return Task.FromResult(Result.Fail<SearchResult>(new ExceptionalError(e)));
        }
    }

    Task<Result<ChapterList>> ISource.GetChapterList(string mangaId, CancellationToken ct)
    {
        try
        {
            return GetChapterList(mangaId, ct);
        }
        catch (Exception e)
        {
            return Task.FromResult(Result.Fail<ChapterList>(new ExceptionalError(e)));
        }
    }

    Task<Result<PageList>> ISource.GetPageList(string chapterId, CancellationToken ct)
    {
        try
        {
            return GetPageList(chapterId, ct);
        }
        catch (Exception e)
        {
            return Task.FromResult(Result.Fail<PageList>(new ExceptionalError(e)));
        }
    }

    Task<Result<byte[]>> ISource.GetImage(string pageId, CancellationToken ct)
    {
        try
        {
            return GetImage(pageId, ct);
        }
        catch (Exception e)
        {
            return Task.FromResult(Result.Fail<byte[]>(new ExceptionalError(e)));
        }
    }
}
