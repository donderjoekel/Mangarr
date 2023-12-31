using System.Net;
using Polly;
using Polly.Extensions.Http;

namespace Mangarr.Backend.Sources.Clients;

public static class ClientExtensions
{
    public static IHttpClientBuilder AddRetryPolicy(this IHttpClientBuilder builder)
    {
        builder.AddPolicyHandler(HttpPolicyExtensions.HandleTransientHttpError()
            .OrResult(msg => msg.StatusCode == HttpStatusCode.TooManyRequests)
            .WaitAndRetryAsync(5, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt))));
        return builder;
    }
}
