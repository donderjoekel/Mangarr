namespace Mangarr.Stack.Sources.Implementations.Custom.Webtoons.Data;

public class SearchResultData
{
    public Result result { get; set; }

    public class Result
    {
        public List<Item> searchedList { get; set; }

        public class Item
        {
            public int titleNo { get; set; }
            public string title { get; set; }
            public string thumbnailMobile { get; set; }
            public string searchMode { get; set; }
        }
    }
}
