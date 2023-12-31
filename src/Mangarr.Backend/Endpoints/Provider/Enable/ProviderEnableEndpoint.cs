using Mangarr.Backend.Database.Documents;
using Mangarr.Shared.Models;
using Mangarr.Shared.Requests;
using Mangarr.Shared.Responses;
using MongoDB.Driver;
using IMapper = AutoMapper.IMapper;

namespace Mangarr.Backend.Endpoints.Provider.Enable;

public class ProviderEnableEndpoint : Endpoint<ProviderEnableRequest, ProviderEnableResponse>
{
    private readonly IMongoCollection<SourceDocument> _providerCollection;
    private readonly IMapper _mapper;

    public ProviderEnableEndpoint(IMongoCollection<SourceDocument> providerCollection, IMapper mapper)
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
        SourceDocument? providerDocument = await _providerCollection
            .Find(x => x.Identifier == req.Provider)
            .FirstOrDefaultAsync(ct);

        if (providerDocument == null)
        {
            await SendNotFoundAsync(ct);
            return;
        }

        providerDocument.Enabled = true;

        UpdateResult result = await _providerCollection.UpdateOneAsync(
            SourceDocument.Filter.Eq(x => x.Identifier, req.Provider),
            SourceDocument.Update.Set(x => x.Enabled, true),
            null,
            ct);

        // TODO: Check result

        await SendOkAsync(new ProviderEnableResponse() { Data = _mapper.Map<ProviderModel>(providerDocument) },
            ct);
    }
}
