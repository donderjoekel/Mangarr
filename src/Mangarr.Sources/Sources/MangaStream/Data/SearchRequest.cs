namespace Mangarr.Sources.Sources.MangaStream.Data;

public class SearchRequest
{
    public string action = "ts_ac_do_search";
    public string ts_ac_query;

    public SearchRequest(string query) => ts_ac_query = query;
}
