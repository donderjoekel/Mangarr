using Mangarr.Stack.Database.Documents;
using MongoDB.Driver;

namespace Mangarr.Stack.Database.Repositories;

public class MangaMetadataRepository : RepositoryBase<MangaMetadataDocument>
{
    public MangaMetadataRepository(IMongoCollection<MangaMetadataDocument> collection)
        : base(collection)
    {
    }

    public MangaMetadataDocument? GetByManga(RequestedMangaDocument requestedMangaDocument) =>
        GetByManga(requestedMangaDocument.Id);

    public MangaMetadataDocument? GetByManga(string mangaId) =>
        this.FirstOrDefault(x => x.MangaId == mangaId);
}
