namespace Mangarr.Stack.Database.Repositories;

public interface IRepository
{
    Task Initialize();
}

// public interface IRepository<TDocument> : IRepository, IEnumerable<TDocument>
//     where TDocument : DocumentBase<TDocument>
// {
//     TDocument? this[string id] { get; }
//     IEnumerable<TDocument> Items { get; }
//     Task<TDocument?> FindAsync(FilterDefinition<TDocument> filter);
//     Task<TDocument> AddAsync(TDocument document);
//     Task<TDocument> UpdateAsync(TDocument document);
//     Task<TDocument> UpdateAsync(string id, UpdateDefinition<TDocument> update);
//     Task<TDocument> UpdateAsync(FilterDefinition<TDocument> filter, UpdateDefinition<TDocument> update);
//     Task<DeleteResult> DeleteAsync(string id);
//     Task<DeleteResult> DeleteAsync(TDocument document);
//     Task<DeleteResult> DeleteAsync(FilterDefinition<TDocument> filter);
//     Task<DeleteResult> DeleteManyAsync(FilterDefinition<TDocument> filter);
// }
