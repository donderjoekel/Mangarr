using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace Mangarr.Stack.Caching;

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
        value = default;

        RedisValue redisValue = _database.StringGet(key);
        if (!redisValue.HasValue)
        {
            return false;
        }

        try
        {
            JsonData? jsonData = JsonConvert.DeserializeObject<JsonData>(redisValue!, _serializerSettings);

            if (jsonData == null)
            {
                _logger.LogError("Deserialization from cache returned null");
                return false;
            }

            if (jsonData.Value is not T converted)
            {
                _logger.LogError("Failed to convert value from cache");
                return false;
            }

            value = converted;
            return true;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Failed to deserialize value from cache");
            return false;
        }
    }

    public void Set<T>(string key, T value, TimeSpan? expiry = null)
    {
        JsonData jsonData = new() { Value = value };
        string serializedValue = JsonConvert.SerializeObject(jsonData, _serializerSettings);
        _database.StringSet(key, serializedValue, expiry);
    }

    private class JsonData
    {
        public object Value { get; set; } = null!;
    }
}
