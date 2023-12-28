using Mandarr.Backend.Database.Documents;
using Mandarr.Shared.Models;
using Mandarr.Shared.Requests;
using Mandarr.Shared.Responses;
using MongoDB.Driver;
using IMapper = AutoMapper.IMapper;

namespace Mandarr.Backend.Endpoints.Provider.Enable;

public class ProviderEnableEndpoint : Endpoint<ProviderEnableRequest, ProviderEnableResponse>
{
    private readonly IMongoCollection<ProviderDocument> _providerCollection;
    private readonly IMapper _mapper;

    public ProviderEnableEndpoint(IMongoCollection<ProviderDocument> providerCollection, IMapper mapper)
    {
        _providerCollection = providerCollection;
        _mapper = mapper;
    }

    public override void Configure()
    {
        Post("/provider/{provider}/enable");
        AllowAnonymous();
    }

    public override async Task HandleAsync(ProviderEnableRequest req, CancellationToken ct)
    {
        ProviderDocument? providerDocument = await _providerCollection
            .Find(x => x.Identifier == req.Provider)
            .FirstOrDefaultAsync(ct);

        if (providerDocument == null)
        {
            await SendNotFoundAsync(ct);
            return;
        }

        providerDocument.Enabled = true;

        UpdateResult result = await _providerCollection.UpdateOneAsync(
            ProviderDocument.Filter.Eq(x => x.Identifier, req.Provider),
            ProviderDocument.Update.Set(x => x.Enabled, true),
            null,
            ct);

        // TODO: Check result

        await SendOkAsync(new ProviderEnableResponse()
            {
                Data = _mapper.Map<ProviderModel>(providerDocument)
            },
            ct);
    }
}
