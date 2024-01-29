using Newtonsoft.Json;
using SixLabors.ImageSharp.Formats.Webp;

namespace Mangarr.Stack.Settings;

public partial class SettingsApi
{
    public partial class ConversionSettings
    {
        public class WebpConversionSettings
        {
            private const string SubSection = "Conversion.Webp";

            [JsonProperty] private WebpEncodingMethod _level = WebpEncodingMethod.Default;
            [JsonProperty] private WebpFileFormatType _lossless;
            [JsonProperty] private bool _nearLossless;
            [JsonProperty] private int _nearLosslessQuality = 60;
            [JsonProperty] private int _quality = 75;

            [JsonIgnore]
            public WebpEncodingMethod Level
            {
                get => _level;
                set
                {
                    _level = value;
                    _writer.Save(SubSection, this);
                }
            }

            [JsonIgnore]
            public WebpFileFormatType Lossless
            {
                get => _lossless;
                set
                {
                    _lossless = value;
                    _writer.Save(SubSection, this);
                }
            }

            [JsonIgnore]
            public bool NearLossless
            {
                get => _nearLossless;
                set
                {
                    _nearLossless = value;
                    _writer.Save(SubSection, this);
                }
            }

            [JsonIgnore]
            public int NearLosslessQuality
            {
                get => _nearLosslessQuality;
                set
                {
                    _nearLosslessQuality = value;
                    _writer.Save(SubSection, this);
                }
            }

            [JsonIgnore]
            public int Quality
            {
                get => _quality;
                set
                {
                    _quality = value;
                    _writer.Save(SubSection, this);
                }
            }

            public WebpConversionSettings() => _reader.Load(SubSection, this);
        }
    }
}
