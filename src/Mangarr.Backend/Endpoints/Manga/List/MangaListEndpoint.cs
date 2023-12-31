using Mangarr.Shared.Models;
using Mangarr.Shared.Requests;
using Mangarr.Shared.Responses;
using MongoDB.Driver;
using IMapper = AutoMapper.IMapper;
using RequestedMangaDocument = Mangarr.Backend.Database.Documents.RequestedMangaDocument;

namespace Mangarr.Backend.Endpoints.Manga.List;

public class MangaListEndpoint : Endpoint<MangaListRequest, MangaListResponse>
{
    private readonly IMongoCollection<RequestedMangaDocument> _collection;
    private readonly IMapper _mapper;

    public MangaListEndpoint(IMongoCollection<RequestedMangaDocument> collection, IMapper mapper)
    {
        _collection = collection;
        _mapper = mapper;
    }

    public override void Configure()
    {
        Get("/manga");
        AllowAnonymous();
    }

    public override async Task HandleAsync(MangaListRequest req, CancellationToken ct)
    {
        List<RequestedMangaDocument> requests = await _collection
            .Find(x => true)
            .ToListAsync(ct);

        await SendOkAsync(
            new MangaListResponse { Data = requests.Select(x => _mapper.Map<RequestedMangaModel>(x)).ToList() },
            ct);
    }
}
