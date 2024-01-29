using Newtonsoft.Json;
using SixLabors.ImageSharp.Formats.Png;

namespace Mangarr.Stack.Settings;

public partial class SettingsApi
{
    public partial class ConversionSettings
    {
        public class PngConversionSettings
        {
            private const string SubSection = "Conversion.Png";

            [JsonProperty] private PngBitDepth? _bitDepth;
            [JsonProperty] private PngChunkFilter? _chunkFilter;
            [JsonProperty] private PngColorType? _colorType;
            [JsonProperty] private PngCompressionLevel _compressionLevel;
            [JsonProperty] private PngFilterMethod? _filterMethod;
            [JsonProperty] private PngInterlaceMode? _interlaceMode;
            [JsonProperty] private PngTransparentColorMode _transparentColorMode;

            [JsonIgnore]
            public PngBitDepth? BitDepth
            {
                get => _bitDepth;
                set
                {
                    _bitDepth = value;
                    _writer.Save(SubSection, this);
                }
            }

            [JsonIgnore]
            public PngChunkFilter? ChunkFilter
            {
                get => _chunkFilter;
                set
                {
                    _chunkFilter = value;
                    _writer.Save(SubSection, this);
                }
            }

            [JsonIgnore]
            public PngColorType? ColorType
            {
                get => _colorType;
                set
                {
                    _colorType = value;
                    _writer.Save(SubSection, this);
                }
            }

            [JsonIgnore]
            public PngCompressionLevel CompressionLevel
            {
                get => _compressionLevel;
                set
                {
                    _compressionLevel = value;
                    _writer.Save(SubSection, this);
                }
            }

            [JsonIgnore]
            public PngFilterMethod? FilterMethod
            {
                get => _filterMethod;
                set
                {
                    _filterMethod = value;
                    _writer.Save(SubSection, this);
                }
            }

            [JsonIgnore]
            public PngInterlaceMode? InterlaceMode
            {
                get => _interlaceMode;
                set
                {
                    _interlaceMode = value;
                    _writer.Save(SubSection, this);
                }
            }

            [JsonIgnore]
            public PngTransparentColorMode TransparentColorMode
            {
                get => _transparentColorMode;
                set
                {
                    _transparentColorMode = value;
                    _writer.Save(SubSection, this);
                }
            }

            public PngConversionSettings() => _reader.Load(SubSection, this);
        }
    }
}
