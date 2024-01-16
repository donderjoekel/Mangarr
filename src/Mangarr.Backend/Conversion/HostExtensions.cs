namespace Mangarr.Backend.Conversion;

public static class HostExtensions
{
    public static void AddMangarrConversion(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<ConversionOptions>(builder.Configuration.GetSection(ConversionOptions.Section));
        builder.Services.AddSingleton<ConversionService>();
    }
}
