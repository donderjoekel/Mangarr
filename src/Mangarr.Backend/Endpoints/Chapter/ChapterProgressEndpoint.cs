using Mangarr.Shared.Models;
using Mangarr.Shared.Requests;
using Mangarr.Shared.Responses;
using MongoDB.Driver;
using IMapper = AutoMapper.IMapper;

namespace Mangarr.Backend.Endpoints.Chapter;

public class ChapterProgressEndpoint : Endpoint<ChapterProgressRequest, ChapterProgressResponse>
{
    private readonly IMapper _mapper;
    private readonly IMongoCollection<ChapterProgressDocument> _progressCollection;

    public ChapterProgressEndpoint(IMongoCollection<ChapterProgressDocument> progressCollection, IMapper mapper)
    {
        _progressCollection = progressCollection;
        _mapper = mapper;
    }

    public override void Configure()
    {
        Get("chapter/progress");
        AllowAnonymous();
    }

    public override async Task HandleAsync(ChapterProgressRequest req, CancellationToken ct)
    {
        List<ChapterProgressDocument> chapterProgressDocuments = await _progressCollection
            .Find(x => true)
            .ToListAsync(ct);

        await SendOkAsync(new ChapterProgressResponse
            {
                Data = chapterProgressDocuments.Select(x => _mapper.Map<ChapterProgressModel>(x)).ToList()
            },
            ct);
    }
}
