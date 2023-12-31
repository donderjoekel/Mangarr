using System.Text;

namespace Mangarr.Backend.Sources.Extensions;

public static class StringExtensions
{
    public static string ToBase64(this string input) => Convert.ToBase64String(Encoding.UTF8.GetBytes(input));

    public static string FromBase64(this string input) => Encoding.UTF8.GetString(Convert.FromBase64String(input));
}
