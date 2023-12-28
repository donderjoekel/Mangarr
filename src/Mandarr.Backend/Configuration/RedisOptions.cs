namespace Mandarr.Backend.Configuration;

public class RedisOptions
{
    public const string SECTION = "Redis";

    public string Host { get; set; }
    public string Password { get; set; }
}
