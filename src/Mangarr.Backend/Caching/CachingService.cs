using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace Mangarr.Backend.Caching;

public class CachingService
{
    private readonly IDatabase _database;
    private readonly ILogger<CachingService> _logger;
    private readonly JsonSerializerSettings _serializerSettings;

    public CachingService(IDatabase database, ILogger<CachingService> logger)
    {
        _database = database;
        _logger = logger;

        _serializerSettings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
    }

    public bool HasKey(string key) => _database.KeyExists(key);

    public bool TryGetValue<T>(string key, [NotNullWhen(true)] out T? value)
    {
        RedisValue redisValue = _database.StringGet(key);
        if (redisValue.HasValue)
        {
            try
            {
                value = JsonConvert.DeserializeObject<T>(redisValue!, _serializerSettings)!;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Failed to deserialize value from cache");
                value = default;
                return false;
            }

            return true;
        }

        value = default;
        return false;
    }

    public void Set<T>(string key, T value, TimeSpan? expiry = null)
    {
        string serializedValue = JsonConvert.SerializeObject(value, _serializerSettings);
        _database.StringSet(key, serializedValue, expiry);
    }
}
