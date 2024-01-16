namespace Mangarr.Backend.Conversion;

public class WebPOptions
{
    public bool Enabled { get; set; }
    public int Level { get; set; } = 4;
    public bool Lossless { get; set; }
    public int Quality { get; set; } = 75;
    public bool NearLossless { get; set; }
    public int NearLosslessQuality { get; set; } = 60;
}
