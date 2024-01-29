namespace Mangarr.Stack.Conversion;

public static class HostExtensions
{
    public static void AddMangarrConversion(this WebApplicationBuilder builder) =>
        builder.Services.AddSingleton<ConversionService>();
}
