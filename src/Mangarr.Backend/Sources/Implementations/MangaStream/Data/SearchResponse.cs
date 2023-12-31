namespace Mangarr.Backend.Sources.Implementations.MangaStream.Data;

public class SearchResponse
{
    public class Series
    {
        public class All
        {
            public int ID { get; set; }
            public string post_image { get; set; }
            public string post_title { get; set; }
            public string post_link { get; set; }
        }

        public All[] all { get; set; }
    }

    public Series[] series { get; set; }
}
