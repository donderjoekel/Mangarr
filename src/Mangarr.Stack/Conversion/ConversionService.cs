using FluentResults;
using Mangarr.Stack.Settings;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Formats.Webp;

namespace Mangarr.Stack.Conversion;

public class ConversionService
{
    private readonly SettingsApi _settingsApi;

    public ConversionService(SettingsApi settingsApi) => _settingsApi = settingsApi;

    public Task<Result<byte[]>> Convert(byte[] input)
    {
        switch (_settingsApi.Conversion.ConversionMode)
        {
            case ConversionMode.None:
                return Task.FromResult(Result.Ok(input));
            case ConversionMode.Webp:
                return ConvertToWebP(input);
            case ConversionMode.Jpeg:
                return ConvertToJpeg(input);
            case ConversionMode.Png:
                return ConvertToPng(input);
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public string GetExtension() =>
        _settingsApi.Conversion.ConversionMode switch
        {
            ConversionMode.None => ".png",
            ConversionMode.Webp => ".webp",
            ConversionMode.Jpeg => ".jpg",
            ConversionMode.Png => ".png",
            _ => throw new ArgumentOutOfRangeException()
        };

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
                Method = _settingsApi.Conversion.Webp.Level,
                FileFormat = _settingsApi.Conversion.Webp.Lossless,
                Quality = _settingsApi.Conversion.Webp.Quality,
                NearLossless = _settingsApi.Conversion.Webp.NearLossless,
                NearLosslessQuality = _settingsApi.Conversion.Webp.NearLosslessQuality
            });

    private Task<Result<byte[]>> ConvertToPng(byte[] input) =>
        Convert(input,
            new PngEncoder
            {
                ColorType = _settingsApi.Conversion.Png.ColorType,
                BitDepth = _settingsApi.Conversion.Png.BitDepth,
                CompressionLevel = _settingsApi.Conversion.Png.CompressionLevel,
                FilterMethod = _settingsApi.Conversion.Png.FilterMethod,
                InterlaceMethod = _settingsApi.Conversion.Png.InterlaceMode,
                ChunkFilter = _settingsApi.Conversion.Png.ChunkFilter,
                TransparentColorMode = _settingsApi.Conversion.Png.TransparentColorMode
            });

    private Task<Result<byte[]>> ConvertToJpeg(byte[] input) =>
        Convert(input,
            new JpegEncoder
            {
                ColorType = _settingsApi.Conversion.Jpeg.ColorType,
                Quality = _settingsApi.Conversion.Jpeg.Quality,
                Interleaved = _settingsApi.Conversion.Jpeg.Interleaved
            });
}
