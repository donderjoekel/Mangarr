using AngleSharp.Dom;
using AngleSharp.Html.Parser;

namespace Mangarr.Backend.Sources;

internal abstract partial class SourceBase
{
    protected IDocument CreateDocument(string html) => new HtmlParser().ParseDocument(html);

    protected DateTime ParseRelativeDate(string input)
    {
        string[] parts = input.Split(' ');

        if (!int.TryParse(parts[0], out int number))
        {
            throw new ArgumentException("Invalid input");
        }

        string unit = parts[1].ToLower();

        switch (unit)
        {
            case "second":
            case "seconds":
                return DateTime.Now.AddSeconds(-number);
            case "minute":
            case "minutes":
                return DateTime.Now.AddMinutes(-number);
            case "hour":
            case "hours":
                return DateTime.Now.AddHours(-number);
            case "day":
            case "days":
                return DateTime.Now.AddDays(-number);
            case "week":
            case "weeks":
                return DateTime.Now.AddDays(-number * 7);
            case "month":
            case "months":
                return DateTime.Now.AddMonths(-number);
            case "year":
            case "years":
                return DateTime.Now.AddYears(-number);
            default:
                throw new ArgumentException("Invalid time unit");
        }
    }
}
