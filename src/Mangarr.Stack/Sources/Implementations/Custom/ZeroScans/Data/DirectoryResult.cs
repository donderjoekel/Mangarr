namespace Mangarr.Stack.Sources.Implementations.Custom.ZeroScans.Data;

internal class DirectoryResult
{
    public bool success { get; set; }
    public Data data { get; set; }

    public class Data
    {
        public Comic[] comics { get; set; }

        public class Comic
        {
            public int id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
            public Cover cover { get; set; }

            public class Cover
            {
                public string? horizontal { get; set; }
                public string? vertical { get; set; }
            }
        }
    }
}
