using FluentResults;
using Mandarr.Backend.Database.Documents;
using Mandarr.Shared.Models;
using Mandarr.Shared.Requests;
using Mandarr.Shared.Responses;
using Mandarr.Sources;
using Mandarr.Sources.Models.Search;
using MongoDB.Driver;
using IMapper = AutoMapper.IMapper;

namespace Mandarr.Backend.Endpoints.Provider.Search;

public class ProviderSearchEndpoint : Endpoint<ProviderSearchRequest, ProviderSearchResponse>
{
    private readonly IEnumerable<ISource> _providers;
    private readonly IMongoCollection<ProviderDocument> _providerCollection;
    private readonly IMapper _mapper;

    public ProviderSearchEndpoint(
        IEnumerable<ISource> providers,
        IMongoCollection<ProviderDocument> providerCollection,
        IMapper mapper
    )
    {
        _providers = providers;
        _providerCollection = providerCollection;
        _mapper = mapper;
    }

    public override void Configure()
    {
        Get("/provider/{provider}/search/{query}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(ProviderSearchRequest req, CancellationToken ct)
    {
        ProviderDocument providerDocument = await _providerCollection
            .Find(x => x.Identifier == req.Provider)
            .FirstOrDefaultAsync(ct);

        if (providerDocument == null)
        {
            await SendNotFoundAsync(ct);
            return;
        }

        if (!providerDocument.Enabled)
        {
            await SendNoContentAsync(ct);
            return;
        }

        ISource? provider =
            _providers.FirstOrDefault(x =>
                string.Equals(x.Identifier, req.Provider, StringComparison.InvariantCulture));

        if (provider == null)
        {
            await SendNotFoundAsync(ct);
            return;
        }

        Result<SearchResult> result = await provider.Search(req.Query);

        if (result.IsFailed)
        {
            Logger.LogError("Unable to search provider {Id}: {Result}", provider.Identifier, result);
            ThrowError("Unable to search provider", 500);
        }

        await SendOkAsync(new ProviderSearchResponse()
            {
                Data = result.Value.Items.Select(x => _mapper.Map<ProviderMangaModel>(x)).ToList()
            },
            ct);
    }
}
