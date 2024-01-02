using System.Globalization;

namespace Mangarr.Frontend.Extensions;

public static class StringExtensions
{
    public static string ReplaceAll(this string input, string? newValue, params string[] oldValues)
    {
        string result = input;

        foreach (string oldValue in oldValues)
        {
            result = result.Replace(oldValue, newValue);
        }

        return result;
    }

    public static string ReplaceAll(
        this string input,
        string? newValue,
        StringComparison comparisonType,
        params string[] oldValues
    )
    {
        string result = input;

        foreach (string oldValue in oldValues)
        {
            result = result.Replace(oldValue, newValue, comparisonType);
        }

        return result;
    }

    public static string ReplaceAll(
        this string input,
        string? newValue,
        bool ignoreCase,
        CultureInfo? culture,
        params string[] oldValues
    )
    {
        string result = input;

        foreach (string oldValue in oldValues)
        {
            result = result.Replace(oldValue, newValue, ignoreCase, culture);
        }

        return result;
    }
}
