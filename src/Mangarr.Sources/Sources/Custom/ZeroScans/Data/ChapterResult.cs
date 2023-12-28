namespace Mangarr.Sources.Sources.Custom.ZeroScans.Data;

internal class ChapterResult
{
    public class Data
    {
        public class Item
        {
            public int id { get; set; }
            public int name { get; set; }
        }

        public int current_page { get; set; }
        public int? to { get; set; }
        public Item[] data { get; set; }
    }

    public bool success { get; set; }
    public Data data { get; set; }
}
