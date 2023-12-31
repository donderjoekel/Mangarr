using FluentResults;

namespace Mangarr.Backend.Sources.FluentResults;

public class UrlReason : IReason
{
    public UrlReason(string url)
    {
        Url = url;
        Message = $"Url: {url}";
    }

    public string Url { get; }
    public string Message { get; set; }
    public Dictionary<string, object>? Metadata { get; set; }
}
