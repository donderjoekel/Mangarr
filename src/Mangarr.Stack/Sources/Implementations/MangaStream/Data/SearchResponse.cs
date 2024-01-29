namespace Mangarr.Stack.Sources.Implementations.MangaStream.Data;

public class SearchResponse
{
    public Series[] series { get; set; }

    public class Series
    {
        public All[] all { get; set; }

        public class All
        {
            public int ID { get; set; }
            public string post_image { get; set; }
            public string post_title { get; set; }
            public string post_link { get; set; }
        }
    }
}
