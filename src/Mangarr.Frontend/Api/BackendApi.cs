using FluentResults;
using Mangarr.Shared.Requests;
using Mangarr.Shared.Responses;

namespace Mangarr.Frontend.Api;

public class BackendApi
{
    private readonly BackendHttpClient _httpClient;

    public BackendApi(BackendHttpClient httpClient) => _httpClient = httpClient;

    public Task<Result<MangaListResponse>> GetMangaList() => _httpClient.Get<MangaListResponse>("manga");

    public Task<Result<MangaSearchResponse>> Search(string query) =>
        _httpClient.Get<MangaSearchResponse>($"manga/search/{query}/1");

    public Task<Result<ChapterProgressResponse>> GetChapterProgress() =>
        _httpClient.Get<ChapterProgressResponse>("chapter/progress");

    public Task<Result<MangaDetailsResponse>> GetMangaDetails(string id) =>
        _httpClient.Get<MangaDetailsResponse>($"manga/{id}/details");

    public Task<Result<MangaChaptersResponse>> GetMangaChapters(string id) =>
        _httpClient.Get<MangaChaptersResponse>($"manga/{id}/chapters");

    public Task<Result<MangaTitlesResponse>> GetMangaTitles(int id) =>
        _httpClient.Get<MangaTitlesResponse>($"manga/{id}/titles");

    public Task<Result<ProviderListResponse>> GetProviderList() => _httpClient.Get<ProviderListResponse>("provider");

    public Task<Result<ProviderEnableResponse>> EnableProvider(string identifier) =>
        _httpClient.Post<ProviderEnableResponse>($"provider/{identifier}/enable", new { });

    public Task<Result<ProviderDisableResponse>> DisableProvider(string identifier) =>
        _httpClient.Post<ProviderDisableResponse>($"provider/{identifier}/disable", new { });

    public Task<Result<ProviderSearchResponse>> SearchProvider(string identifier, string query) =>
        _httpClient.Get<ProviderSearchResponse>($"provider/{identifier}/search/{query}");

    public Task<Result<MangaRequestResponse>> RequestManga(
        int searchId,
        string providerIdentifier,
        string mangaId,
        bool newChaptersOnly
    ) =>
        _httpClient.Post<MangaRequestResponse>("manga/request",
            new MangaRequestRequest
            {
                SearchId = searchId,
                ProviderId = providerIdentifier,
                MangaId = mangaId,
                NewChaptersOnly = newChaptersOnly
            });

    public Task<Result> DeleteManga(string id, bool deleteChaptersFromDisk) =>
        _httpClient.Post($"manga/{id}/delete",
            new MangaDeleteRequest { Id = id, DeleteChaptersFromDisk = deleteChaptersFromDisk });

    public Task<Result<string>> RefreshManga(string id) => _httpClient.Get($"manga/{id}/refresh");

    public Task<Result<JobsQueueResponse>> GetJobQueue() =>
        _httpClient.Get<JobsQueueResponse>("jobs/queue");

    public Task<Result<JobsScheduleResponse>> GetJobSchedule() =>
        _httpClient.Get<JobsScheduleResponse>("jobs/schedule");

    public Task<Result<string>> TriggerJob(string group, string name) =>
        _httpClient.Get($"jobs/{group}/{name}/trigger");

    public Task<Result<ChapterEnableResponse>> EnableChapter(string id) =>
        _httpClient.Post<ChapterEnableResponse>($"chapter/{id}/enable", new { });

    public Task<Result<ChapterDisableResponse>> DisableChapter(string id) =>
        _httpClient.Post<ChapterDisableResponse>($"chapter/{id}/disable", new { });

    public Task<Result<MangaEnableChaptersResponse>> EnableMangaChapters(string id) =>
        _httpClient.Post<MangaEnableChaptersResponse>($"manga/{id}/enable/chapters", new { });

    public Task<Result<MangaDisableChaptersResponse>> DisableMangaChapters(string id) =>
        _httpClient.Post<MangaDisableChaptersResponse>($"manga/{id}/disable/chapters", new { });
}
