using Mandarr.Backend.Database.Documents;
using Mandarr.Shared.Models;
using Mandarr.Shared.Requests;
using Mandarr.Shared.Responses;
using MongoDB.Driver;
using IMapper = AutoMapper.IMapper;

namespace Mandarr.Backend.Endpoints.Provider.Disable;

public class ProviderDisableEndpoint : Endpoint<ProviderDisableRequest, ProviderDisableResponse>
{
    private readonly IMongoCollection<ProviderDocument> _providerCollection;
    private readonly IMapper _mapper;

    public ProviderDisableEndpoint(IMongoCollection<ProviderDocument> providerCollection, IMapper mapper)
    {
        _providerCollection = providerCollection;
        _mapper = mapper;
    }

    public override void Configure()
    {
        Post("/provider/{provider}/disable");
        AllowAnonymous();
    }

    public override async Task HandleAsync(ProviderDisableRequest req, CancellationToken ct)
    {
        ProviderDocument? providerDocument = await _providerCollection
            .Find(x => x.Identifier == req.Provider)
            .FirstOrDefaultAsync(ct);

        if (providerDocument == null)
        {
            await SendNotFoundAsync(ct);
            return;
        }

        providerDocument.Enabled = false;

        UpdateResult result = await _providerCollection.UpdateOneAsync(
            ProviderDocument.Filter.Eq(x => x.Identifier, req.Provider),
            ProviderDocument.Update.Set(x => x.Enabled, false),
            null,
            ct);

        // TODO: Check result

        await SendOkAsync(new ProviderDisableResponse()
            {
                Data = _mapper.Map<ProviderModel>(providerDocument)
            },
            ct);
    }
}
