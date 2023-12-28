namespace Mandarr.Sources.Sources.Madara.Data;

public class SearchRequest
{
    public string action = "wp-manga-search-manga";
    public string title;

    public SearchRequest(string title) => this.title = title;
}
