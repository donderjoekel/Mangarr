using System.IO.Compression;
using System.Xml;
using System.Xml.Serialization;
using FluentResults;
using Mangarr.Backend.Data;

namespace Mangarr.Backend.Services;

public class ArchiveService
{
    public async Task<Result<byte[]>> CreateArchive(
        ComicInfo comicInfo,
        byte[] coverImageBytes,
        List<byte[]> pages,
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

                ZipArchiveEntry coverImageEntry = archive.CreateEntry("000_cover.jpg", CompressionLevel.Optimal);
                await using (Stream coverImageStream = coverImageEntry.Open())
                {
                    await coverImageStream.WriteAsync(coverImageBytes, ct);
                    await coverImageStream.FlushAsync(ct);
                }

                for (int i = 0; i < pages.Count; i++)
                {
                    byte[] bytes = pages[i];
                    ZipArchiveEntry pageEntry = archive.CreateEntry($"{i + 1:000}.jpg", CompressionLevel.Optimal);
                    await using Stream pageStream = pageEntry.Open();
                    await pageStream.WriteAsync(bytes, ct);
                }
            }

            await zipStream.FlushAsync(ct);
            return zipStream.ToArray();
        }
        catch (Exception e)
        {
            return Result.Fail(new ExceptionalError(e));
        }
    }
}
