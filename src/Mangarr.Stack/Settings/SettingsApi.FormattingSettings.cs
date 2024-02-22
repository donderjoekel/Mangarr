using Newtonsoft.Json;

namespace Mangarr.Stack.Settings;

public partial class SettingsApi
{
    public class FormattingSettings
    {
        private const string Section = "Formatting";
        private readonly SettingsWriter _writer;

        [JsonProperty] private string _charactersToStrip = string.Empty;
        [JsonProperty] private string _format = "{mangaTitle} - {chapterTitle}";
        [JsonProperty] private string _invalidCharacterReplacement = "_";

        [JsonIgnore]
        public string Format
        {
            get => _format;
            set
            {
                _format = value;
                _writer.Save(Section, this);
            }
        }

        [JsonIgnore]
        public string Strip
        {
            get => _charactersToStrip;
            set
            {
                _charactersToStrip = value;
                _writer.Save(Section, this);
            }
        }

        [JsonIgnore]
        public string InvalidCharacterReplacement
        {
            get => _invalidCharacterReplacement;
            set
            {
                _invalidCharacterReplacement = value;
                _writer.Save(Section, this);
            }
        }

        public FormattingSettings(SettingsReader reader, SettingsWriter writer)
        {
            reader.Load(Section, this);
            _writer = writer;
        }
    }
}
