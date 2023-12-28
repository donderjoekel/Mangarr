using FluentResults;
using Mandarr.Shared.Requests;
using Mandarr.Shared.Responses;

namespace Mandarr.Frontend.Api;

public class BackendApi
{
    private readonly BackendHttpClient _httpClient;

    public BackendApi(BackendHttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public Task<Result<MangaListResponse>> GetMangaList()
    {
        return _httpClient.Get<MangaListResponse>("manga");
    }

    public Task<Result<MangaSearchResponse>> Search(string query)
    {
        return _httpClient.Get<MangaSearchResponse>($"manga/search/{query}/1");
    }

    public Task<Result<ChapterProgressResponse>> GetChapterProgress()
    {
        return _httpClient.Get<ChapterProgressResponse>("chapter/progress");
    }

    public Task<Result<MangaDetailsResponse>> GetMangaDetails(string id)
    {
        return _httpClient.Get<MangaDetailsResponse>($"manga/{id}/details");
    }

    public Task<Result<MangaChaptersResponse>> GetMangaChapters(string id)
    {
        return _httpClient.Get<MangaChaptersResponse>($"manga/{id}/chapters");
    }

    public Task<Result<MangaTitlesResponse>> GetMangaTitles(int id)
    {
        return _httpClient.Get<MangaTitlesResponse>($"manga/{id}/titles");
    }

    public Task<Result<ProviderListResponse>> GetProviderList()
    {
        return _httpClient.Get<ProviderListResponse>("provider");
    }

    public Task<Result<ProviderEnableResponse>> EnableProvider(string identifier)
    {
        return _httpClient.Post<ProviderEnableResponse>($"provider/{identifier}/enable", new { });
    }

    public Task<Result<ProviderDisableResponse>> DisableProvider(string identifier)
    {
        return _httpClient.Post<ProviderDisableResponse>($"provider/{identifier}/disable", new { });
    }

    public Task<Result<ProviderSearchResponse>> SearchProvider(string identifier, string query)
    {
        return _httpClient.Get<ProviderSearchResponse>($"provider/{identifier}/search/{query}");
    }

    public Task<Result<MangaRequestResponse>> RequestManga(
        int searchId,
        string providerIdentifier,
        string mangaId,
        bool newChaptersOnly
    )
    {
        return _httpClient.Post<MangaRequestResponse>("manga/request",
            new MangaRequestRequest()
            {
                SearchId = searchId,
                ProviderId = providerIdentifier,
                MangaId = mangaId,
                NewChaptersOnly = newChaptersOnly
            });
    }

    public Task<Result> DeleteManga(string id, bool deleteChaptersFromDisk)
    {
        return _httpClient.Post($"manga/{id}/delete",
            new MangaDeleteRequest()
            {
                Id = id,
                DeleteChaptersFromDisk = deleteChaptersFromDisk
            });
    }
}
