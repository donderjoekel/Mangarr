namespace Mangarr.Backend.Sources.Implementations.Madara.Data;

public class SearchResponse
{
    public class Data
    {
        public string title { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }

    public bool success { get; set; }
    public Data[] data { get; set; }
}
