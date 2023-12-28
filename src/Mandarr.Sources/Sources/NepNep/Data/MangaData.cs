using Newtonsoft.Json;

namespace Mandarr.Sources.Sources.NepNep.Data;

internal class MangaData
{
    public class Item
    {
        [JsonProperty("i")] public string Slug { get; set; } = null!;
        [JsonProperty("s")] public string Title { get; set; } = null!;
    }

    public Item[] Directory { get; set; } = null!;
}
