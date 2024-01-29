using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Mangarr.Stack.Settings;

public class SettingsReader
{
    private readonly IWebHostEnvironment _environment;

    public SettingsReader(IWebHostEnvironment environment) => _environment = environment;

    public void Load<T>(string section, T target)
    {
        string path = Path.Combine(_environment.ContentRootPath, "appsettings.json");

        if (!File.Exists(path))
        {
            return;
        }

        string json = File.ReadAllText(path);
        JObject jObject = JObject.Parse(json);

        if (!jObject.ContainsKey(section))
        {
            return;
        }

        JToken? jToken = jObject[section];

        if (jToken == null)
        {
            return;
        }

        JsonConvert.PopulateObject(jToken.ToString(), target);
    }
}
