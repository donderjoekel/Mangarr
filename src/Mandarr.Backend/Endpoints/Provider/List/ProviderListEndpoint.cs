using Mandarr.Backend.Database.Documents;
using Mandarr.Shared.Models;
using Mandarr.Shared.Requests;
using Mandarr.Shared.Responses;
using MongoDB.Driver;
using IMapper = AutoMapper.IMapper;

namespace Mandarr.Backend.Endpoints.Provider.List;

public class ProviderListEndpoint : Endpoint<ProviderListRequest, ProviderListResponse>
{
    private readonly IMongoCollection<ProviderDocument> _providerCollection;
    private readonly IMapper _mapper;

    public ProviderListEndpoint(IMongoCollection<ProviderDocument> providerCollection, IMapper mapper)
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
        List<ProviderDocument> providerDocuments = await _providerCollection.Find(x => true).ToListAsync(ct);

        await SendOkAsync(new ProviderListResponse()
            {
                Data = providerDocuments.Select(x => _mapper.Map<ProviderModel>(x)).ToList()
            },
            ct);
    }
}
