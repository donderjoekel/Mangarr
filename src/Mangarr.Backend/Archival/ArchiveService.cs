using System.IO.Compression;
using System.Xml;
using System.Xml.Serialization;
using FluentResults;
using Mangarr.Backend.Cover;
using Mangarr.Backend.Data;
using Mangarr.Backend.Downloading;

namespace Mangarr.Backend.Archival;

public class ArchiveService
{
    public async Task<Result<Archive>> CreateArchive(
        ComicInfo comicInfo,
        CoverImage coverImage,
        DownloadedPages downloadedPages,
        CancellationToken ct
    )
    {
        try
        {
            using MemoryStream zipStream = new();
            using (ZipArchive archive = new(zipStream, ZipArchiveMode.Create))
            {
                ZipArchiveEntry comicInfoEntry = archive.CreateEntry("ComicInfo.xml", CompressionLevel.Optimal);
                await using (Stream comicInfoStream = comicInfoEntry.Open())
                {
                    XmlSerializer serializer = new(typeof(ComicInfo));
                    XmlWriterSettings xmlWriterSettings = new() { Async = true, Indent = true };

                    await using (XmlWriter writer = XmlWriter.Create(comicInfoStream, xmlWriterSettings))
                    {
                        serializer.Serialize(writer, comicInfo);
                        await writer.FlushAsync();
                    }
                }

                ZipArchiveEntry coverImageEntry =
                    archive.CreateEntry("000_cover" + coverImage.Extension, CompressionLevel.Optimal);
                await using (Stream coverImageStream = coverImageEntry.Open())
                {
                    await coverImageStream.WriteAsync(coverImage.Data, ct);
                    await coverImageStream.FlushAsync(ct);
                }

                for (int i = 0; i < downloadedPages.Pages.Count; i++)
                {
                    DownloadedPage page = downloadedPages.Pages[i];
                    ZipArchiveEntry pageEntry = archive.CreateEntry((i + 1).ToString("000") + page.Extension,
                        CompressionLevel.Optimal);
                    await using Stream pageStream = pageEntry.Open();
                    await pageStream.WriteAsync(page.Data, ct);
                }
            }

            await zipStream.FlushAsync(ct);
            return new Archive(zipStream.ToArray(), ".cbz"); // TODO: Support for multiple archive formats
        }
        catch (Exception e)
        {
            return Result.Fail(new ExceptionalError(e));
        }
    }
}
