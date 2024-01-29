namespace Mangarr.Stack.Extensions;

public static class EnumerableExtensions
{
    public static string JoinToString(this IEnumerable<string> enumerable, char separator) =>
        string.Join(separator, enumerable);

    public static string JoinToString(this IEnumerable<string> enumerable, string separator) =>
        string.Join(separator, enumerable);

    public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> enumerable) =>
        enumerable.Select((item, index) => (item, index));
}
