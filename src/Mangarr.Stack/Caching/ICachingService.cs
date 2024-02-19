using System.Diagnostics.CodeAnalysis;

namespace Mangarr.Stack.Caching;

public interface ICachingService
{
    bool HasKey(string key);
    bool TryGetValue<T>(string key, [NotNullWhen(true)] out T? value);
    void Set<T>(string key, T value, TimeSpan? expiry = null);
}
