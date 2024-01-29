using Mangarr.Stack.Database.Documents;
using MongoDB.Driver;

namespace Mangarr.Stack.Database.Repositories;

public class SourceRepository : RepositoryBase<SourceDocument>
{
    public SourceRepository(IMongoCollection<SourceDocument> collection)
        : base(collection)
    {
    }

    public SourceDocument? GetByIdentifier(string identifier) => this.FirstOrDefault(x => x.Identifier == identifier);
}
