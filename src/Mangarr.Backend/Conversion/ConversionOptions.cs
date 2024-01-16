namespace Mangarr.Backend.Conversion;

public class ConversionOptions
{
    public const string Section = "Conversion";

    public WebPOptions WebP { get; set; } = new();
    public PngOptions Png { get; set; } = new();
    public JpgOptions Jpg { get; set; } = new();
}
