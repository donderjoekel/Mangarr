using Mangarr.Stack.AniList;
using Newtonsoft.Json;

namespace Mangarr.Stack.Settings;

public partial class SettingsApi
{
    public class AniListSettings
    {
        private const string Section = "AniList";
        private readonly SettingsWriter _writer;

        [JsonProperty] private bool _allowAdult;
        [JsonProperty] private AniListPreferredTitleMode _preferredTitleMode;

        [JsonIgnore]
        public bool AllowAdult
        {
            get => _allowAdult;
            set
            {
                _allowAdult = value;
                _writer.Save(Section, this);
            }
        }

        [JsonIgnore]
        public AniListPreferredTitleMode PreferredTitleMode
        {
            get => _preferredTitleMode;
            set
            {
                _preferredTitleMode = value;
                _writer.Save(Section, this);
            }
        }

        public AniListSettings(SettingsReader reader, SettingsWriter writer)
        {
            reader.Load(Section, this);
            _writer = writer;
        }
    }
}
