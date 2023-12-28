using System.Globalization;
using FluentResults;
using Mangarr.Backend.Configuration;
using Mangarr.Backend.Database.Documents;
using Microsoft.Extensions.Options;

namespace Mangarr.Backend.Services;

public class ExportService
{
    private readonly ExportOptions _exportOptions;

    public ExportService(IOptions<ExportOptions> exportOptions) => _exportOptions = exportOptions.Value;

    public async Task<Result> Export(
        RequestedMangaDocument requestedMangaDocument,
        RequestedChapterDocument requestedChapterDocument,
        byte[] archiveBytes
    )
    {
        try
        {
            string mangaTitle = requestedMangaDocument.Title;
            string chapterTitle = requestedChapterDocument.ChapterNumber.ToString(CultureInfo.InvariantCulture);
            string archiveName = $"{mangaTitle} - {chapterTitle}.cbz";
            string archiveDirectory = Path.Combine(_exportOptions.Path, mangaTitle);

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
}
