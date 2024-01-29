namespace Mangarr.Stack.Sources.Implementations.Madara.Data;

public class SearchResponse
{
    public bool success { get; set; }
    public Data[] data { get; set; }

    public class Data
    {
        public string title { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }
}
