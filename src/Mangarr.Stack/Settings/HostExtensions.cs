namespace Mangarr.Stack.Settings;

public static class HostExtensions
{
    public static void AddMangarrSettings(this WebApplicationBuilder builder)
    {
        builder.Services.AddSingleton<SettingsApi>();
        builder.Services.AddSingleton<SettingsReader>();
        builder.Services.AddSingleton<SettingsWriter>();
        builder.Services.AddSingleton<SettingsApi.AniListSettings>();
        builder.Services.AddSingleton<SettingsApi.LibrarySettings>();
        builder.Services.AddSingleton<SettingsApi.ConversionSettings>();
        builder.Services.AddSingleton<SettingsApi.FormattingSettings>();
    }
}
