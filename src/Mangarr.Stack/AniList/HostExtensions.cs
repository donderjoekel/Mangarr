using System.Net;
using Polly;
using Polly.Extensions.Http;

namespace Mangarr.Stack.AniList;

public static class HostExtensions
{
    public static void AddMangarrAniList(this WebApplicationBuilder builder)
    {
        builder.Services.AddSingleton<AniListApi>();
        builder.Services.AddHttpClient("AniList")
            .AddPolicyHandler(HttpPolicyExtensions.HandleTransientHttpError()
                .OrResult(msg => msg.StatusCode == HttpStatusCode.TooManyRequests)
                .WaitAndRetryAsync(5, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt))));
    }
}
