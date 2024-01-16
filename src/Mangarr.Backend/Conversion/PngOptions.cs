namespace Mangarr.Backend.Conversion;

public class PngOptions
{
    public bool Enabled { get; set; }
    public byte? BitDepth { get; set; }
    public byte? ColorType { get; set; }
    public int? FilterMethod { get; set; }
    public int CompressionLevel { get; set; } = 6;
    public byte? InterlaceMode { get; set; }
    public byte? ChunkFilter { get; set; }
    public int TransparentColorMode { get; set; }
}
