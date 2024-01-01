using AngleSharp.Dom;
using AngleSharp.Html.Parser;
using Mangarr.Backend.Sources.Extensions;

namespace Mangarr.Backend.Sources;

internal abstract partial class SourceBase
{
    protected static IDocument CreateDocument(string html) => new HtmlParser().ParseDocument(html);

    protected static bool TryParseRelativeDate(string input, out DateTime result)
    {
        string[] parts = input.Split(' ');

        if (!int.TryParse(parts[0], out int number))
        {
            result = default;
            return false;
        }

        string unit = parts[1].ToLower();

        switch (unit)
        {
            case "second":
            case "seconds":
                result = DateTime.Now.AddSeconds(-number);
                break;
            case "minute":
            case "minutes":
                result = DateTime.Now.AddMinutes(-number);
                break;
            case "hour":
            case "hours":
                result = DateTime.Now.AddHours(-number);
                break;
            case "day":
            case "days":
                result = DateTime.Now.AddDays(-number);
                break;
            case "week":
            case "weeks":
                result = DateTime.Now.AddDays(-number * 7);
                break;
            case "month":
            case "months":
                result = DateTime.Now.AddMonths(-number);
                break;
            case "year":
            case "years":
                result = DateTime.Now.AddYears(-number);
                break;
            default:
                result = default;
                return false;
        }

        return true;
    }

    internal static string ConstructId(string url, params string[] args)
    {
        if (args.Length == 0)
        {
            return url.ToBase64();
        }

        string[] segments = { url, string.Join("|", args) };
        return string.Join("|", segments).ToBase64();
    }

    internal static void DeconstructId(string id, out string url, out string[] args)
    {
        string[] splits = id.FromBase64().Split('|', StringSplitOptions.RemoveEmptyEntries);
        url = splits[0];
        args = splits.Skip(1).ToArray();
    }
}
