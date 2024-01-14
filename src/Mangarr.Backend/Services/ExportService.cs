using System.Globalization;
using FluentResults;
using MongoDB.Driver;
using RequestedChapterDocument = Mangarr.Backend.Database.Documents.RequestedChapterDocument;
using RequestedMangaDocument = Mangarr.Backend.Database.Documents.RequestedMangaDocument;

namespace Mangarr.Backend.Services;

public class ExportService
{
    private readonly IMongoCollection<RootFolderDocument> _rootFolderCollection;

    public ExportService(IMongoCollection<RootFolderDocument> rootFolderCollection) =>
        _rootFolderCollection = rootFolderCollection;

    public async Task<Result> Export(
        RequestedMangaDocument requestedMangaDocument,
        RequestedChapterDocument requestedChapterDocument,
        byte[] archiveBytes
    )
    {
        try
        {
            RootFolderDocument? rootFolderDocument = await _rootFolderCollection
                .Find(x => x.Id == requestedMangaDocument.RootFolderId)
                .FirstOrDefaultAsync();

            if (rootFolderDocument == null)
            {
                return Result.Fail("Root folder missing");
            }

            string mangaTitle = requestedMangaDocument.Title;
            string chapterTitle = requestedChapterDocument.ChapterNumber.ToString(CultureInfo.InvariantCulture);
            string archiveName = $"{mangaTitle} - {chapterTitle}.cbz";
            string archiveDirectory = Path.Combine(rootFolderDocument.Path, mangaTitle);

            if (!Directory.Exists(archiveDirectory))
            {
                Directory.CreateDirectory(archiveDirectory);
            }

            string archivePath = Path.Combine(archiveDirectory, archiveName);
            await File.WriteAllBytesAsync(archivePath, archiveBytes);

            return Result.Ok();
        }
        catch (Exception e)
        {
            return Result.Fail(new ExceptionalError(e));
        }
    }

    public async Task<Result<bool>> DoesChapterExist(
        RequestedMangaDocument requestedMangaDocument,
        RequestedChapterDocument requestedChapterDocument
    )
    {
        RootFolderDocument? rootFolderDocument = await _rootFolderCollection
            .Find(x => x.Id == requestedMangaDocument.RootFolderId)
            .FirstOrDefaultAsync();

        if (rootFolderDocument == null)
        {
            return Result.Fail("Root folder missing");
        }

        string mangaTitle = requestedMangaDocument.Title;
        string chapterTitle = requestedChapterDocument.ChapterNumber.ToString(CultureInfo.InvariantCulture);
        string archiveName = $"{mangaTitle} - {chapterTitle}.cbz";
        string archiveDirectory = Path.Combine(rootFolderDocument.Path, mangaTitle);

        if (!Directory.Exists(archiveDirectory))
        {
            return false;
        }

        string archivePath = Path.Combine(archiveDirectory, archiveName);
        return File.Exists(archivePath);
    }
}
