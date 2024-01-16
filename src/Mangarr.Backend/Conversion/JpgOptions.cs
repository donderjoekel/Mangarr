namespace Mangarr.Backend.Conversion;

public class JpgOptions
{
    public bool Enabled { get; set; }
    public int Quality { get; set; } = 75;
    public bool? Interleaved { get; set; }
    public byte? ColorType { get; set; }
}
