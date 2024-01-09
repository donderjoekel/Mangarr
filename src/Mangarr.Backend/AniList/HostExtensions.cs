namespace Mangarr.Backend.AniList;

public static class HostExtensions
{
    public static void AddMangarrAniList(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<AniListOptions>(builder.Configuration.GetSection(AniListOptions.SECTION));
        builder.Services.AddSingleton<AniListService>();
    }
}
