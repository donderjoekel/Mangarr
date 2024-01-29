using Mangarr.Stack.Database.Documents;
using MongoDB.Driver;

namespace Mangarr.Stack.Database.Repositories;

public class RequestedChapterRepository : RepositoryBase<RequestedChapterDocument>
{
    public RequestedChapterRepository(IMongoCollection<RequestedChapterDocument> collection)
        : base(collection)
    {
    }

    public List<RequestedChapterDocument> GetByMangaId(string mangaId) =>
        this.Where(x => x.RequestedMangaId == mangaId).ToList();
}
