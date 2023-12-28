using Mandarr.Backend.Database.Documents;
using Mandarr.Shared.Models;
using Mandarr.Shared.Requests;
using Mandarr.Shared.Responses;
using MongoDB.Driver;
using IMapper = AutoMapper.IMapper;

namespace Mandarr.Backend.Endpoints.Manga.Chapters;

public class MangaChaptersEndpoint : Endpoint<MangaChaptersRequest, MangaChaptersResponse>
{
    private readonly IMongoCollection<RequestedChapterDocument> _chapterCollection;
    private readonly IMapper _mapper;

    public MangaChaptersEndpoint(IMongoCollection<RequestedChapterDocument> chapterCollection, IMapper mapper)
    {
        _chapterCollection = chapterCollection;
        _mapper = mapper;
    }

    public override void Configure()
    {
        Get("/manga/{id}/chapters");
        AllowAnonymous();
    }

    public override async Task HandleAsync(MangaChaptersRequest req, CancellationToken ct)
    {
        List<RequestedChapterDocument> documents = await _chapterCollection
            .Find(x => x.RequestedMangaId == req.Id)
            .ToListAsync(ct);

        await SendOkAsync(new MangaChaptersResponse()
            {
                Data = documents.Select(x => _mapper.Map<MangaChapterModel>(x)).ToList()
            },
            ct);
    }
}
