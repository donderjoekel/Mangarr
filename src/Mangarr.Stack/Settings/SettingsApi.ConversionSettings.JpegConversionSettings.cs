using Newtonsoft.Json;
using SixLabors.ImageSharp.Formats.Jpeg;

namespace Mangarr.Stack.Settings;

public partial class SettingsApi
{
    public partial class ConversionSettings
    {
        public class JpegConversionSettings
        {
            private const string SubSection = "Conversion.Jpeg";

            [JsonProperty] private JpegEncodingColor _colorType;
            [JsonProperty] private bool? _interleaved;
            [JsonProperty] private int _quality = 75;

            [JsonIgnore]
            public JpegEncodingColor ColorType
            {
                get => _colorType;
                set
                {
                    _colorType = value;
                    _writer.Save(SubSection, this);
                }
            }

            [JsonIgnore]
            public bool? Interleaved
            {
                get => _interleaved;
                set
                {
                    _interleaved = value;
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

            public JpegConversionSettings() => _reader.Load(SubSection, this);
        }
    }
}
