namespace Mandarr.Backend.Extensions;

public static class EnumerableExtensions
{
    public static string JoinToString(this IEnumerable<string> enumerable, char separator) =>
        string.Join(separator, enumerable);

    public static string JoinToString(this IEnumerable<string> enumerable, string separator) =>
        string.Join(separator, enumerable);
}
