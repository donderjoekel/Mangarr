using Mangarr.Stack.Conversion;
using Newtonsoft.Json;

namespace Mangarr.Stack.Settings;

public partial class SettingsApi
{
    public partial class ConversionSettings
    {
        private const string Section = "Conversion";

        // ReSharper disable once PrivateFieldCanBeConvertedToLocalVariable
        private static SettingsReader _reader = null!;

        // ReSharper disable once PrivateFieldCanBeConvertedToLocalVariable
        private static SettingsWriter _writer = null!;

        [JsonProperty] private ConversionMode _conversionMode;

        [JsonIgnore]
        public ConversionMode ConversionMode
        {
            get => _conversionMode;
            set
            {
                _conversionMode = value;
                _writer.Save(Section, this);
            }
        }

        [JsonIgnore] public JpegConversionSettings Jpeg { get; set; }

        [JsonIgnore] public PngConversionSettings Png { get; set; }

        [JsonIgnore] public WebpConversionSettings Webp { get; set; }

        public ConversionSettings(SettingsReader reader, SettingsWriter writer)
        {
            _reader = reader;
            _writer = writer;

            reader.Load(Section, this);

            Jpeg = new JpegConversionSettings();
            Png = new PngConversionSettings();
            Webp = new WebpConversionSettings();
        }
    }
}
