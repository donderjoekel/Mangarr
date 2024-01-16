using FluentResults;
using Microsoft.Extensions.Options;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Formats.Webp;

namespace Mangarr.Backend.Conversion;

public class ConversionService
{
    private readonly ConversionOptions _conversionOptions;

    public ConversionService(IOptions<ConversionOptions> conversionOptions) =>
        _conversionOptions = conversionOptions.Value;

    public Task<Result<byte[]>> Convert(byte[] input)
    {
        if (_conversionOptions.WebP.Enabled)
        {
            return ConvertToWebP(input);
        }

        if (_conversionOptions.Png.Enabled)
        {
            return ConvertToPng(input);
        }

        if (_conversionOptions.Jpg.Enabled)
        {
            return ConvertToJpeg(input);
        }

        return Task.FromResult(Result.Ok(input));
    }

    public string GetExtension()
    {
        if (_conversionOptions.WebP.Enabled)
        {
            return ".webp";
        }

        if (_conversionOptions.Png.Enabled)
        {
            return ".png";
        }

        if (_conversionOptions.Jpg.Enabled)
        {
            return ".jpg";
        }

        return ".png";
    }

    private async Task<Result<byte[]>> Convert(byte[] input, IImageEncoder encoder)
    {
        using MemoryStream inStream = new(input);
        using Image image = await Image.LoadAsync(inStream);
        using MemoryStream outStream = new();
        await image.SaveAsync(outStream, encoder);
        return outStream.ToArray();
    }

    private Task<Result<byte[]>> ConvertToWebP(byte[] input) =>
        Convert(input,
            new WebpEncoder
            {
                Method = (WebpEncodingMethod)_conversionOptions.WebP.Level,
                FileFormat = _conversionOptions.WebP.Lossless
                    ? WebpFileFormatType.Lossless
                    : WebpFileFormatType.Lossy,
                Quality = _conversionOptions.WebP.Quality,
                NearLossless = _conversionOptions.WebP.NearLossless,
                NearLosslessQuality = _conversionOptions.WebP.NearLosslessQuality
            });

    private Task<Result<byte[]>> ConvertToPng(byte[] input) =>
        Convert(input,
            new PngEncoder
            {
                ColorType = (PngColorType?)_conversionOptions.Png.ColorType,
                BitDepth = (PngBitDepth?)_conversionOptions.Png.BitDepth,
                CompressionLevel = (PngCompressionLevel)_conversionOptions.Png.CompressionLevel,
                FilterMethod = (PngFilterMethod?)_conversionOptions.Png.FilterMethod,
                InterlaceMethod = (PngInterlaceMode?)_conversionOptions.Png.InterlaceMode,
                ChunkFilter = (PngChunkFilter?)_conversionOptions.Png.ChunkFilter,
                TransparentColorMode = (PngTransparentColorMode)_conversionOptions.Png.TransparentColorMode
            });

    private Task<Result<byte[]>> ConvertToJpeg(byte[] input) =>
        Convert(input,
            new JpegEncoder
            {
                ColorType = (JpegEncodingColor?)_conversionOptions.Jpg.ColorType,
                Quality = _conversionOptions.Jpg.Quality,
                Interleaved = _conversionOptions.Jpg.Interleaved
            });
}
