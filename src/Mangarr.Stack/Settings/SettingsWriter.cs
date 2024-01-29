using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Mangarr.Stack.Settings;

public class SettingsWriter
{
    private readonly IConfigurationRoot _configuration;
    private readonly IWebHostEnvironment _environment;

    public SettingsWriter(IWebHostEnvironment environment, IConfiguration configuration)
    {
        _environment = environment;

        if (configuration is not IConfigurationRoot configurationRoot)
        {
            throw new ArgumentException("Configuration must be an IConfigurationRoot", nameof(configuration));
        }

        _configuration = configurationRoot;
    }

    public void Save(string section, object options)
    {
        string path = Path.Combine(_environment.ContentRootPath, "appsettings.json");

        JObject jObject;

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            jObject = JObject.Parse(json);
        }
        else
        {
            jObject = new JObject();
        }

        jObject[section] = JObject.FromObject(options);
        string output = JsonConvert.SerializeObject(jObject, Formatting.Indented);
        File.WriteAllText(path, output);
        _configuration.Reload();
    }
}
