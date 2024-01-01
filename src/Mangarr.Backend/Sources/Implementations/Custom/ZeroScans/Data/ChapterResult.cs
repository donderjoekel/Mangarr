namespace Mangarr.Backend.Sources.Implementations.Custom.ZeroScans.Data;

internal class ChapterResult
{
    public bool success { get; set; }
    public Data data { get; set; }

    public class Data
    {
        public int current_page { get; set; }
        public int? to { get; set; }
        public Item[] data { get; set; }

        public class Item
        {
            public int id { get; set; }
            public int name { get; set; }
        }
    }
}
