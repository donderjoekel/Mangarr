using Mangarr.Stack.Database.Documents;
using MongoDB.Driver;

namespace Mangarr.Stack.Database.Repositories;

public class RequestedMangaRepository : RepositoryBase<RequestedMangaDocument>
{
    public RequestedMangaRepository(IMongoCollection<RequestedMangaDocument> collection)
        : base(collection)
    {
    }
}
