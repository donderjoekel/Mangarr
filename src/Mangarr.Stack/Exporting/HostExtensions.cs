namespace Mangarr.Stack.Exporting;

public static class HostExtensions
{
    public static void AddMangarrExporting(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<ExportOptions>(builder.Configuration.GetSection(ExportOptions.SECTION));
        builder.Services.AddSingleton<ExportService>();
    }
}
