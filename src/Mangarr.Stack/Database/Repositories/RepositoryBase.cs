using System.Collections;
using Mangarr.Stack.Database.Documents;
using MongoDB.Driver;

namespace Mangarr.Stack.Database.Repositories;

public class RepositoryBase<TDocument> : IRepository, IEnumerable<TDocument>
    where TDocument : DocumentBase<TDocument>
{
    private readonly IMongoCollection<TDocument> _collection;

    private readonly Dictionary<string, TDocument> _documentsById = new();

    public TDocument? this[string id] => _documentsById.TryGetValue(id, out TDocument? document) ? document : default;

    public IEnumerable<TDocument> Items => _documentsById.Values;

    public RepositoryBase(IMongoCollection<TDocument> collection) => _collection = collection;

    public IEnumerator<TDocument> GetEnumerator() => _documentsById.Values.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    async Task IRepository.Initialize()
    {
        List<TDocument> documents = await _collection.Find(x => true).ToListAsync();
        foreach (TDocument document in documents)
        {
            _documentsById.Add(document.Id, document);
        }
    }

    public async Task<TDocument?> FindAsync(FilterDefinition<TDocument> filter) =>
        await _collection.Find(filter).FirstOrDefaultAsync();

    public async Task<TDocument> AddAsync(TDocument document)
    {
        document.DateCreated = document.DateUpdated = DateTime.UtcNow;
        await _collection.InsertOneAsync(document);
        _documentsById.Add(document.Id, document);
        return document;
    }

    public async Task<(TDocument? document, ReplaceOneResult result)> UpdateAsync(TDocument document)
    {
        document.DateUpdated = DateTime.UtcNow;
        ReplaceOneResult result = await _collection.ReplaceOneAsync(x => x.Id == document.Id, document);
        _documentsById[document.Id] = document;
        return (document, result);
    }

    public async Task<(TDocument? document, UpdateResult result)> UpdateAsync(
        string id,
        UpdateDefinition<TDocument> update
    )
    {
        update = DocumentBase<TDocument>.Update.Combine(update,
            DocumentBase<TDocument>.Update.Set(x => x.DateUpdated, DateTime.UtcNow));
        UpdateResult result = await _collection.UpdateOneAsync(x => x.Id == id, update);
        _documentsById[id] = await _collection.Find(x => x.Id == id).FirstAsync();
        return (_documentsById[id], result);
    }

    public async Task<(TDocument? document, UpdateResult result)> UpdateAsync(
        FilterDefinition<TDocument> filter,
        UpdateDefinition<TDocument> update
    )
    {
        update = DocumentBase<TDocument>.Update.Combine(update,
            DocumentBase<TDocument>.Update.Set(x => x.DateUpdated, DateTime.UtcNow));
        UpdateResult result = await _collection.UpdateOneAsync(filter, update);
        TDocument document = await _collection.Find(filter).FirstAsync();
        _documentsById[document.Id] = document;
        return (_documentsById[document.Id], result);
    }

    public async Task<DeleteResult> DeleteAsync(string id)
    {
        DeleteResult result = await _collection.DeleteOneAsync(x => x.Id == id);
        _documentsById.Remove(id);
        return result;
    }

    public async Task<DeleteResult> DeleteAsync(TDocument document)
    {
        DeleteResult result = await _collection.DeleteOneAsync(x => x.Id == document.Id);
        _documentsById.Remove(document.Id);
        return result;
    }

    public async Task<DeleteResult> DeleteAsync(FilterDefinition<TDocument> filter)
    {
        TDocument document = await _collection.Find(filter).FirstAsync();
        return await DeleteAsync(document);
    }

    public async Task<DeleteResult> DeleteManyAsync(FilterDefinition<TDocument> filter)
    {
        IAsyncCursor<TDocument> cursor = await _collection.FindAsync(filter);
        List<TDocument> documents = await cursor.ToListAsync();
        DeleteResult result = await _collection.DeleteManyAsync(filter);

        foreach (TDocument document in documents)
        {
            _documentsById.Remove(document.Id);
        }

        return result;
    }
}
