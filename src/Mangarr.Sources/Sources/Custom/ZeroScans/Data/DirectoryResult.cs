namespace Mangarr.Sources.Sources.Custom.ZeroScans.Data;

internal class DirectoryResult
{
    public class Data
    {
        public class Comic
        {
            public class Cover
            {
                public string? horizontal { get; set; }
                public string? vertical { get; set; }
            }

            public int id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
            public Cover cover { get; set; }
        }

        public Comic[] comics { get; set; }
    }

    public bool success { get; set; }
    public Data data { get; set; }
}
