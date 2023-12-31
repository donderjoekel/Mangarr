using Mangarr.Shared.Models;
using Mangarr.Shared.Requests;
using Mangarr.Shared.Responses;
using MongoDB.Driver;
using IMapper = AutoMapper.IMapper;

namespace Mangarr.Backend.Endpoints.Provider.Disable;

public class ProviderDisableEndpoint : Endpoint<ProviderDisableRequest, ProviderDisableResponse>
{
    private readonly IMapper _mapper;
    private readonly IMongoCollection<SourceDocument> _providerCollection;

    public ProviderDisableEndpoint(IMongoCollection<SourceDocument> providerCollection, IMapper mapper)
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
        SourceDocument? providerDocument = await _providerCollection
            .Find(x => x.Identifier == req.Provider)
            .FirstOrDefaultAsync(ct);

        if (providerDocument == null)
        {
            await SendNotFoundAsync(ct);
            return;
        }

        providerDocument.Enabled = false;

        UpdateResult result = await _providerCollection.UpdateOneAsync(
            SourceDocument.Filter.Eq(x => x.Identifier, req.Provider),
            SourceDocument.Update.Set(x => x.Enabled, false),
            null,
            ct);

        // TODO: Check result

        await SendOkAsync(new ProviderDisableResponse { Data = _mapper.Map<ProviderModel>(providerDocument) },
            ct);
    }
}
