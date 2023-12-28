﻿using FluentResults;
using Mandarr.Sources.Models.Chapter;
using Mandarr.Sources.Models.Page;
using Mandarr.Sources.Models.Search;

namespace Mandarr.Sources;

internal abstract partial class SourceBase
{
    string ISource.Identifier => Id;
    string ISource.Name => Name;
    string ISource.Url => Url;

    // Task<Result<MangaDirectory>> ISource.GetDirectory()
    // {
    //     try
    //     {
    //         return GetDirectory();
    //     }
    //     catch (Exception e)
    //     {
    //         return Task.FromResult(Result.Fail<MangaDirectory>(new ExceptionalError(e)));
    //     }
    // }

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
