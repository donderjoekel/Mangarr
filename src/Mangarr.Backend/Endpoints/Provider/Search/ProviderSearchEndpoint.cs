using FluentResults;
using Mangarr.Shared.Models;
using Mangarr.Shared.Requests;
using Mangarr.Shared.Responses;
using Mangarr.Sources;
using Mangarr.Sources.Models.Search;
using MongoDB.Driver;
using IMapper = AutoMapper.IMapper;

namespace Mangarr.Backend.Endpoints.Provider.Search;

public class ProviderSearchEndpoint : Endpoint<ProviderSearchRequest, ProviderSearchResponse>
{
    private readonly IMapper _mapper;
    private readonly IMongoCollection<SourceDocument> _providerCollection;
    private readonly IEnumerable<ISource> _providers;

    public ProviderSearchEndpoint(
        IEnumerable<ISource> providers,
        IMongoCollection<SourceDocument> providerCollection,
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
        SourceDocument sourceDocument = await _providerCollection
            .Find(x => x.Identifier == req.Provider)
            .FirstOrDefaultAsync(ct);

        if (sourceDocument == null)
        {
            await SendNotFoundAsync(ct);
            return;
        }

        if (!sourceDocument.Enabled)
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

        await SendOkAsync(new ProviderSearchResponse
            {
                Data = result.Value.Items.Select(x => _mapper.Map<ProviderMangaModel>(x)).ToList()
            },
            ct);
    }
}
