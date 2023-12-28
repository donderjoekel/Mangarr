using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace Mangarr.Backend.Services;

public class CachingService
{
    private readonly IDatabase _database;

    public CachingService(IDatabase database) => _database = database;

    public bool HasKey(string key) => _database.KeyExists(key);

    public bool TryGetValue<T>(string key, [NotNullWhen(true)] out T? value)
    {
        RedisValue redisValue = _database.StringGet(key);
        if (redisValue.HasValue)
        {
            value = JsonConvert.DeserializeObject<T>(redisValue!)!;
            return true;
        }

        value = default;
        return false;
    }

    public void Set<T>(string key, T value, TimeSpan? expiry = null)
    {
        string serializedValue = JsonConvert.SerializeObject(value);
        _database.StringSet(key, serializedValue, expiry);
    }
}
