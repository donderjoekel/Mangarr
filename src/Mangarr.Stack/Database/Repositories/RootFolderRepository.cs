using Mangarr.Stack.Database.Documents;
using MongoDB.Driver;

namespace Mangarr.Stack.Database.Repositories;

public class RootFolderRepository : RepositoryBase<RootFolderDocument>
{
    public RootFolderRepository(IMongoCollection<RootFolderDocument> collection)
        : base(collection)
    {
    }

    public RootFolderDocument? GetForManga(RequestedMangaDocument requestedMangaDocument) =>
        this.FirstOrDefault(x => x.Id == requestedMangaDocument.RootFolderId);
}
