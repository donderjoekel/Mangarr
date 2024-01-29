using System.Globalization;
using FluentResults;
using Mangarr.Stack.AniList;
using Mangarr.Stack.Archival;
using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;
using RequestedChapterDocument = Mangarr.Stack.Database.Documents.RequestedChapterDocument;
using RequestedMangaDocument = Mangarr.Stack.Database.Documents.RequestedMangaDocument;

namespace Mangarr.Stack.Exporting;

public class ExportService
{
    private readonly AniListApi _aniListApi;
    private readonly RootFolderRepository _rootFolderRepository;

    public ExportService(AniListApi aniListApi, RootFolderRepository rootFolderRepository)
    {
        _aniListApi = aniListApi;
        _rootFolderRepository = rootFolderRepository;
    }

    public async Task<Result> Export(
        RequestedMangaDocument requestedMangaDocument,
        RequestedChapterDocument requestedChapterDocument,
        Archive archive
    )
    {
        try
        {
            RootFolderDocument? rootFolderDocument = _rootFolderRepository.GetForManga(requestedMangaDocument);

            if (rootFolderDocument == null)
            {
                return Result.Fail("Root folder missing");
            }

            string mangaTitle = _aniListApi.GetPreferredTitle(requestedMangaDocument);
            string chapterTitle = requestedChapterDocument.ChapterNumber.ToString(CultureInfo.InvariantCulture);
            string archiveName = $"{mangaTitle} - {chapterTitle}.cbz"; // TODO: Support archive extension
            string archiveDirectory = Path.Combine(rootFolderDocument.Path, mangaTitle);

            if (!Directory.Exists(archiveDirectory))
            {
                Directory.CreateDirectory(archiveDirectory);
            }

            string archivePath = Path.Combine(archiveDirectory, archiveName);
            await File.WriteAllBytesAsync(archivePath, archive.Data);

            return Result.Ok();
        }
        catch (Exception e)
        {
            return Result.Fail(new ExceptionalError(e));
        }
    }

    public Result<bool> DoesChapterExist(
        RequestedMangaDocument requestedMangaDocument,
        RequestedChapterDocument requestedChapterDocument
    )
    {
        RootFolderDocument? rootFolderDocument = _rootFolderRepository.GetForManga(requestedMangaDocument);

        if (rootFolderDocument == null)
        {
            return Result.Fail<bool>("Root folder missing");
        }

        string mangaTitle = _aniListApi.GetPreferredTitle(requestedMangaDocument);
        string chapterTitle = requestedChapterDocument.ChapterNumber.ToString(CultureInfo.InvariantCulture);
        string archiveName = $"{mangaTitle} - {chapterTitle}.cbz"; // TODO: Support archive extension
        string archiveDirectory = Path.Combine(rootFolderDocument.Path, mangaTitle);

        if (!Directory.Exists(archiveDirectory))
        {
            return false;
        }

        string archivePath = Path.Combine(archiveDirectory, archiveName);
        return File.Exists(archivePath);
    }

    public Result DeleteChapter(
        RequestedMangaDocument requestedMangaDocument,
        RequestedChapterDocument requestedChapterDocument
    )
    {
        try
        {
            RootFolderDocument? rootFolderDocument = _rootFolderRepository.GetForManga(requestedMangaDocument);

            if (rootFolderDocument == null)
            {
                return Result.Fail("Root folder missing");
            }

            string mangaTitle = _aniListApi.GetPreferredTitle(requestedMangaDocument);
            string chapterTitle = requestedChapterDocument.ChapterNumber.ToString(CultureInfo.InvariantCulture);
            string archiveName = $"{mangaTitle} - {chapterTitle}.cbz"; // TODO: Support archive extension
            string archiveDirectory = Path.Combine(rootFolderDocument.Path, mangaTitle);
            string archivePath = Path.Combine(archiveDirectory, archiveName);

            if (File.Exists(archivePath))
            {
                File.Delete(archivePath);
            }

            return Result.Ok();
        }
        catch (Exception e)
        {
            return Result.Fail(new ExceptionalError(e));
        }
    }

    public Result<string> GetDestinationFolder(RequestedMangaDocument requestedMangaDocument)
    {
        RootFolderDocument? rootFolderDocument = _rootFolderRepository.GetForManga(requestedMangaDocument);

        if (rootFolderDocument == null)
        {
            return Result.Fail("Root folder missing");
        }

        string mangaTitle = _aniListApi.GetPreferredTitle(requestedMangaDocument);
        return Path.Combine(rootFolderDocument.Path, mangaTitle);
    }
}
