using Newtonsoft.Json;

namespace Mangarr.Stack.Sources.Implementations.NepNep.Data;

internal class MangaData
{
    public Item[] Directory { get; set; } = null!;

    public class Item
    {
        [JsonProperty("i")] public string Slug { get; set; } = null!;
        [JsonProperty("s")] public string Title { get; set; } = null!;
    }
}
