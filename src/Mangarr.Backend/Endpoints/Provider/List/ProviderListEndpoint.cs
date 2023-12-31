using Mangarr.Shared.Models;
using Mangarr.Shared.Requests;
using Mangarr.Shared.Responses;
using MongoDB.Driver;
using IMapper = AutoMapper.IMapper;

namespace Mangarr.Backend.Endpoints.Provider.List;

public class ProviderListEndpoint : Endpoint<ProviderListRequest, ProviderListResponse>
{
    private readonly IMapper _mapper;
    private readonly IMongoCollection<SourceDocument> _providerCollection;

    public ProviderListEndpoint(IMongoCollection<SourceDocument> providerCollection, IMapper mapper)
    {
        _providerCollection = providerCollection;
        _mapper = mapper;
    }

    public override void Configure()
    {
        Get("provider");
        AllowAnonymous();
    }

    public override async Task HandleAsync(ProviderListRequest req, CancellationToken ct)
    {
        List<SourceDocument> providerDocuments = await _providerCollection.Find(x => true).ToListAsync(ct);

        await SendOkAsync(new ProviderListResponse
            {
                Data = providerDocuments.Select(x => _mapper.Map<ProviderModel>(x)).ToList()
            },
            ct);
    }
}
