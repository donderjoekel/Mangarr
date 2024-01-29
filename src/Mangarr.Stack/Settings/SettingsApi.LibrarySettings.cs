using Mangarr.Stack.Library;
using Newtonsoft.Json;

namespace Mangarr.Stack.Settings;

public partial class SettingsApi
{
    public class LibrarySettings
    {
        private const string Section = "Library";
        private readonly SettingsWriter _writer;

        [JsonProperty] private bool _ascending;
        [JsonProperty] private LibraryDisplayMode _displayMode;
        [JsonProperty] private LibrarySortMode _sortMode;

        [JsonIgnore]
        public LibraryDisplayMode DisplayMode
        {
            get => _displayMode;
            set
            {
                _displayMode = value;
                _writer.Save(Section, this);
            }
        }

        [JsonIgnore]
        public LibrarySortMode SortMode
        {
            get => _sortMode;
            set
            {
                _sortMode = value;
                _writer.Save(Section, this);
            }
        }

        [JsonIgnore]
        public bool Ascending
        {
            get => _ascending;
            set
            {
                _ascending = value;
                _writer.Save(Section, this);
            }
        }

        public LibrarySettings(SettingsReader reader, SettingsWriter writer)
        {
            reader.Load(Section, this);
            _writer = writer;
        }
    }
}
