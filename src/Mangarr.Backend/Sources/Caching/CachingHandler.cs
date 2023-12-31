using System.Security.Cryptography;
using System.Text;
using Mangarr.Backend.Services;

namespace Mangarr.Backend.Sources.Caching;

public class CachingHandler : DelegatingHandler
{
    public const string BypassCacheKey = "X-Mangarr-Cache-Bypass";

    private readonly CachingService _cachingService;

    public CachingHandler(CachingService cachingService) => _cachingService = cachingService;

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken
    )
    {
        if (request.Headers.Contains(BypassCacheKey))
        {
            return await base.SendAsync(request, cancellationToken);
        }

        string url = request.RequestUri?.ToString() ?? string.Empty;
        string method = request.Method.ToString();
        string body = request.Content?.ReadAsStringAsync(cancellationToken).Result ?? string.Empty;

        string regularKey = $"{url}{method}{body}";
        byte[] regularKeyBytes = Encoding.UTF8.GetBytes(regularKey);
        byte[] hashedKeyBytes = SHA256.HashData(regularKeyBytes);
        string hashedKey = Convert.ToBase64String(hashedKeyBytes);

        if (_cachingService.TryGetValue(hashedKey, out CachedResponseMessage? cachedResponse))
        {
            return cachedResponse.ToHttpResponseMessage();
        }

        HttpResponseMessage response = await base.SendAsync(request, cancellationToken);
        CachedResponseMessage cachedResponseMessage = new(response);
        await cachedResponseMessage.SaveContent();
        _cachingService.Set(hashedKey, cachedResponseMessage, TimeSpan.FromMinutes(5));
        return response;
    }
}
