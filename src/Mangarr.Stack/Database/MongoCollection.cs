using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MongoDB.Driver.Search;

namespace Mangarr.Stack.Database;

public class MongoCollection<T> : IMongoCollection<T>
{
    private readonly IMongoCollection<T> _collection;

    public MongoCollection(CollectionFactory collectionFactory) =>
        _collection = collectionFactory.Create<T>(typeof(T).Name);

    IAsyncCursor<TResult> IMongoCollection<T>.Aggregate<TResult>(
        PipelineDefinition<T, TResult> pipeline,
        AggregateOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.Aggregate(pipeline, options, cancellationToken);

    IAsyncCursor<TResult> IMongoCollection<T>.Aggregate<TResult>(
        IClientSessionHandle session,
        PipelineDefinition<T, TResult> pipeline,
        AggregateOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.Aggregate(session, pipeline, options, cancellationToken);

    Task<IAsyncCursor<TResult>> IMongoCollection<T>.AggregateAsync<TResult>(
        PipelineDefinition<T, TResult> pipeline,
        AggregateOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.AggregateAsync(pipeline, options, cancellationToken);

    Task<IAsyncCursor<TResult>> IMongoCollection<T>.AggregateAsync<TResult>(
        IClientSessionHandle session,
        PipelineDefinition<T, TResult> pipeline,
        AggregateOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.AggregateAsync(session, pipeline, options, cancellationToken);

    void IMongoCollection<T>.AggregateToCollection<TResult>(
        PipelineDefinition<T, TResult> pipeline,
        AggregateOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.AggregateToCollection(pipeline, options, cancellationToken);

    void IMongoCollection<T>.AggregateToCollection<TResult>(
        IClientSessionHandle session,
        PipelineDefinition<T, TResult> pipeline,
        AggregateOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.AggregateToCollection(session, pipeline, options, cancellationToken);

    Task IMongoCollection<T>.AggregateToCollectionAsync<TResult>(
        PipelineDefinition<T, TResult> pipeline,
        AggregateOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.AggregateToCollectionAsync(pipeline, options, cancellationToken);

    Task IMongoCollection<T>.AggregateToCollectionAsync<TResult>(
        IClientSessionHandle session,
        PipelineDefinition<T, TResult> pipeline,
        AggregateOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.AggregateToCollectionAsync(session, pipeline, options, cancellationToken);

    BulkWriteResult<T> IMongoCollection<T>.BulkWrite(
        IEnumerable<WriteModel<T>> requests,
        BulkWriteOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.BulkWrite(requests, options, cancellationToken);

    BulkWriteResult<T> IMongoCollection<T>.BulkWrite(
        IClientSessionHandle session,
        IEnumerable<WriteModel<T>> requests,
        BulkWriteOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.BulkWrite(session, requests, options, cancellationToken);

    Task<BulkWriteResult<T>> IMongoCollection<T>.BulkWriteAsync(
        IEnumerable<WriteModel<T>> requests,
        BulkWriteOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.BulkWriteAsync(requests, options, cancellationToken);

    Task<BulkWriteResult<T>> IMongoCollection<T>.BulkWriteAsync(
        IClientSessionHandle session,
        IEnumerable<WriteModel<T>> requests,
        BulkWriteOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.BulkWriteAsync(session, requests, options, cancellationToken);

    long IMongoCollection<T>.Count(
        FilterDefinition<T> filter,
        CountOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.Count(filter, options, cancellationToken);

    long IMongoCollection<T>.Count(
        IClientSessionHandle session,
        FilterDefinition<T> filter,
        CountOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.Count(session, filter, options, cancellationToken);

    Task<long> IMongoCollection<T>.CountAsync(
        FilterDefinition<T> filter,
        CountOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.CountAsync(filter, options, cancellationToken);

    Task<long> IMongoCollection<T>.CountAsync(
        IClientSessionHandle session,
        FilterDefinition<T> filter,
        CountOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.CountAsync(session, filter, options, cancellationToken);

    long IMongoCollection<T>.CountDocuments(
        FilterDefinition<T> filter,
        CountOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.CountDocuments(filter, options, cancellationToken);

    long IMongoCollection<T>.CountDocuments(
        IClientSessionHandle session,
        FilterDefinition<T> filter,
        CountOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.CountDocuments(session, filter, options, cancellationToken);

    Task<long> IMongoCollection<T>.CountDocumentsAsync(
        FilterDefinition<T> filter,
        CountOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.CountDocumentsAsync(filter, options, cancellationToken);

    Task<long> IMongoCollection<T>.CountDocumentsAsync(
        IClientSessionHandle session,
        FilterDefinition<T> filter,
        CountOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.CountDocumentsAsync(session, filter, options, cancellationToken);

    DeleteResult IMongoCollection<T>.DeleteMany(FilterDefinition<T> filter, CancellationToken cancellationToken) =>
        _collection.DeleteMany(filter, cancellationToken);

    DeleteResult IMongoCollection<T>.DeleteMany(
        FilterDefinition<T> filter,
        DeleteOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.DeleteMany(filter, options, cancellationToken);

    DeleteResult IMongoCollection<T>.DeleteMany(
        IClientSessionHandle session,
        FilterDefinition<T> filter,
        DeleteOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.DeleteMany(session, filter, options, cancellationToken);

    Task<DeleteResult> IMongoCollection<T>.DeleteManyAsync(
        FilterDefinition<T> filter,
        CancellationToken cancellationToken
    ) =>
        _collection.DeleteManyAsync(filter, cancellationToken);

    Task<DeleteResult> IMongoCollection<T>.DeleteManyAsync(
        FilterDefinition<T> filter,
        DeleteOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.DeleteManyAsync(filter, options, cancellationToken);

    Task<DeleteResult> IMongoCollection<T>.DeleteManyAsync(
        IClientSessionHandle session,
        FilterDefinition<T> filter,
        DeleteOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.DeleteManyAsync(session, filter, options, cancellationToken);

    DeleteResult IMongoCollection<T>.DeleteOne(FilterDefinition<T> filter, CancellationToken cancellationToken) =>
        _collection.DeleteOne(filter, cancellationToken);

    DeleteResult IMongoCollection<T>.DeleteOne(
        FilterDefinition<T> filter,
        DeleteOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.DeleteOne(filter, options, cancellationToken);

    DeleteResult IMongoCollection<T>.DeleteOne(
        IClientSessionHandle session,
        FilterDefinition<T> filter,
        DeleteOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.DeleteOne(session, filter, options, cancellationToken);

    Task<DeleteResult> IMongoCollection<T>.DeleteOneAsync(
        FilterDefinition<T> filter,
        CancellationToken cancellationToken
    ) =>
        _collection.DeleteOneAsync(filter, cancellationToken);

    Task<DeleteResult> IMongoCollection<T>.DeleteOneAsync(
        FilterDefinition<T> filter,
        DeleteOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.DeleteOneAsync(filter, options, cancellationToken);

    Task<DeleteResult> IMongoCollection<T>.DeleteOneAsync(
        IClientSessionHandle session,
        FilterDefinition<T> filter,
        DeleteOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.DeleteOneAsync(session, filter, options, cancellationToken);

    IAsyncCursor<TField> IMongoCollection<T>.Distinct<TField>(
        FieldDefinition<T, TField> field,
        FilterDefinition<T> filter,
        DistinctOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.Distinct(field, filter, options, cancellationToken);

    IAsyncCursor<TField> IMongoCollection<T>.Distinct<TField>(
        IClientSessionHandle session,
        FieldDefinition<T, TField> field,
        FilterDefinition<T> filter,
        DistinctOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.Distinct(session, field, filter, options, cancellationToken);

    Task<IAsyncCursor<TField>> IMongoCollection<T>.DistinctAsync<TField>(
        FieldDefinition<T, TField> field,
        FilterDefinition<T> filter,
        DistinctOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.DistinctAsync(field, filter, options, cancellationToken);

    Task<IAsyncCursor<TField>> IMongoCollection<T>.DistinctAsync<TField>(
        IClientSessionHandle session,
        FieldDefinition<T, TField> field,
        FilterDefinition<T> filter,
        DistinctOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.DistinctAsync(session, field, filter, options, cancellationToken);

    long IMongoCollection<T>.EstimatedDocumentCount(
        EstimatedDocumentCountOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.EstimatedDocumentCount(options, cancellationToken);

    Task<long> IMongoCollection<T>.EstimatedDocumentCountAsync(
        EstimatedDocumentCountOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.EstimatedDocumentCountAsync(options, cancellationToken);

    IAsyncCursor<TProjection> IMongoCollection<T>.FindSync<TProjection>(
        FilterDefinition<T> filter,
        FindOptions<T, TProjection> options,
        CancellationToken cancellationToken
    ) =>
        _collection.FindSync(filter, options, cancellationToken);

    IAsyncCursor<TProjection> IMongoCollection<T>.FindSync<TProjection>(
        IClientSessionHandle session,
        FilterDefinition<T> filter,
        FindOptions<T, TProjection> options,
        CancellationToken cancellationToken
    ) =>
        _collection.FindSync(session, filter, options, cancellationToken);

    Task<IAsyncCursor<TProjection>> IMongoCollection<T>.FindAsync<TProjection>(
        FilterDefinition<T> filter,
        FindOptions<T, TProjection> options,
        CancellationToken cancellationToken
    ) =>
        _collection.FindAsync(filter, options, cancellationToken);

    Task<IAsyncCursor<TProjection>> IMongoCollection<T>.FindAsync<TProjection>(
        IClientSessionHandle session,
        FilterDefinition<T> filter,
        FindOptions<T, TProjection> options,
        CancellationToken cancellationToken
    ) =>
        _collection.FindAsync(session, filter, options, cancellationToken);

    TProjection IMongoCollection<T>.FindOneAndDelete<TProjection>(
        FilterDefinition<T> filter,
        FindOneAndDeleteOptions<T, TProjection> options,
        CancellationToken cancellationToken
    ) =>
        _collection.FindOneAndDelete(filter, options, cancellationToken);

    TProjection IMongoCollection<T>.FindOneAndDelete<TProjection>(
        IClientSessionHandle session,
        FilterDefinition<T> filter,
        FindOneAndDeleteOptions<T, TProjection> options,
        CancellationToken cancellationToken
    ) =>
        _collection.FindOneAndDelete(session, filter, options, cancellationToken);

    Task<TProjection> IMongoCollection<T>.FindOneAndDeleteAsync<TProjection>(
        FilterDefinition<T> filter,
        FindOneAndDeleteOptions<T, TProjection> options,
        CancellationToken cancellationToken
    ) =>
        _collection.FindOneAndDeleteAsync(filter, options, cancellationToken);

    Task<TProjection> IMongoCollection<T>.FindOneAndDeleteAsync<TProjection>(
        IClientSessionHandle session,
        FilterDefinition<T> filter,
        FindOneAndDeleteOptions<T, TProjection> options,
        CancellationToken cancellationToken
    ) =>
        _collection.FindOneAndDeleteAsync(session, filter, options, cancellationToken);

    TProjection IMongoCollection<T>.FindOneAndReplace<TProjection>(
        FilterDefinition<T> filter,
        T replacement,
        FindOneAndReplaceOptions<T, TProjection> options,
        CancellationToken cancellationToken
    ) =>
        _collection.FindOneAndReplace(filter, replacement, options, cancellationToken);

    TProjection IMongoCollection<T>.FindOneAndReplace<TProjection>(
        IClientSessionHandle session,
        FilterDefinition<T> filter,
        T replacement,
        FindOneAndReplaceOptions<T, TProjection> options,
        CancellationToken cancellationToken
    ) =>
        _collection.FindOneAndReplace(session, filter, replacement, options, cancellationToken);

    Task<TProjection> IMongoCollection<T>.FindOneAndReplaceAsync<TProjection>(
        FilterDefinition<T> filter,
        T replacement,
        FindOneAndReplaceOptions<T, TProjection> options,
        CancellationToken cancellationToken
    ) =>
        _collection.FindOneAndReplaceAsync(filter, replacement, options, cancellationToken);

    Task<TProjection> IMongoCollection<T>.FindOneAndReplaceAsync<TProjection>(
        IClientSessionHandle session,
        FilterDefinition<T> filter,
        T replacement,
        FindOneAndReplaceOptions<T, TProjection> options,
        CancellationToken cancellationToken
    ) =>
        _collection.FindOneAndReplaceAsync(session, filter, replacement, options, cancellationToken);

    TProjection IMongoCollection<T>.FindOneAndUpdate<TProjection>(
        FilterDefinition<T> filter,
        UpdateDefinition<T> update,
        FindOneAndUpdateOptions<T, TProjection> options,
        CancellationToken cancellationToken
    ) =>
        _collection.FindOneAndUpdate(filter, update, options, cancellationToken);

    TProjection IMongoCollection<T>.FindOneAndUpdate<TProjection>(
        IClientSessionHandle session,
        FilterDefinition<T> filter,
        UpdateDefinition<T> update,
        FindOneAndUpdateOptions<T, TProjection> options,
        CancellationToken cancellationToken
    ) =>
        _collection.FindOneAndUpdate(session, filter, update, options, cancellationToken);

    Task<TProjection> IMongoCollection<T>.FindOneAndUpdateAsync<TProjection>(
        FilterDefinition<T> filter,
        UpdateDefinition<T> update,
        FindOneAndUpdateOptions<T, TProjection> options,
        CancellationToken cancellationToken
    ) =>
        _collection.FindOneAndUpdateAsync(filter, update, options, cancellationToken);

    Task<TProjection> IMongoCollection<T>.FindOneAndUpdateAsync<TProjection>(
        IClientSessionHandle session,
        FilterDefinition<T> filter,
        UpdateDefinition<T> update,
        FindOneAndUpdateOptions<T, TProjection> options,
        CancellationToken cancellationToken
    ) =>
        _collection.FindOneAndUpdateAsync(session, filter, update, options, cancellationToken);

    void IMongoCollection<T>.InsertOne(
        T document,
        InsertOneOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.InsertOne(document, options, cancellationToken);

    void IMongoCollection<T>.InsertOne(
        IClientSessionHandle session,
        T document,
        InsertOneOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.InsertOne(session, document, options, cancellationToken);

    Task IMongoCollection<T>.InsertOneAsync(T document, CancellationToken _cancellationToken) =>
        _collection.InsertOneAsync(document, _cancellationToken);

    Task IMongoCollection<T>.InsertOneAsync(
        T document,
        InsertOneOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.InsertOneAsync(document, options, cancellationToken);

    Task IMongoCollection<T>.InsertOneAsync(
        IClientSessionHandle session,
        T document,
        InsertOneOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.InsertOneAsync(session, document, options, cancellationToken);

    void IMongoCollection<T>.InsertMany(
        IEnumerable<T> documents,
        InsertManyOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.InsertMany(documents, options, cancellationToken);

    void IMongoCollection<T>.InsertMany(
        IClientSessionHandle session,
        IEnumerable<T> documents,
        InsertManyOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.InsertMany(session, documents, options, cancellationToken);

    Task IMongoCollection<T>.InsertManyAsync(
        IEnumerable<T> documents,
        InsertManyOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.InsertManyAsync(documents, options, cancellationToken);

    Task IMongoCollection<T>.InsertManyAsync(
        IClientSessionHandle session,
        IEnumerable<T> documents,
        InsertManyOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.InsertManyAsync(session, documents, options, cancellationToken);

    IAsyncCursor<TResult> IMongoCollection<T>.MapReduce<TResult>(
        BsonJavaScript map,
        BsonJavaScript reduce,
        MapReduceOptions<T, TResult> options,
        CancellationToken cancellationToken
    ) =>
        _collection.MapReduce(map, reduce, options, cancellationToken);

    IAsyncCursor<TResult> IMongoCollection<T>.MapReduce<TResult>(
        IClientSessionHandle session,
        BsonJavaScript map,
        BsonJavaScript reduce,
        MapReduceOptions<T, TResult> options,
        CancellationToken cancellationToken
    ) =>
        _collection.MapReduce(session, map, reduce, options, cancellationToken);

    Task<IAsyncCursor<TResult>> IMongoCollection<T>.MapReduceAsync<TResult>(
        BsonJavaScript map,
        BsonJavaScript reduce,
        MapReduceOptions<T, TResult> options,
        CancellationToken cancellationToken
    ) =>
        _collection.MapReduceAsync(map, reduce, options, cancellationToken);

    Task<IAsyncCursor<TResult>> IMongoCollection<T>.MapReduceAsync<TResult>(
        IClientSessionHandle session,
        BsonJavaScript map,
        BsonJavaScript reduce,
        MapReduceOptions<T, TResult> options,
        CancellationToken cancellationToken
    ) =>
        _collection.MapReduceAsync(session, map, reduce, options, cancellationToken);

    IFilteredMongoCollection<TDerivedDocument> IMongoCollection<T>.OfType<TDerivedDocument>() =>
        _collection.OfType<TDerivedDocument>();

    ReplaceOneResult IMongoCollection<T>.ReplaceOne(
        FilterDefinition<T> filter,
        T replacement,
        ReplaceOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.ReplaceOne(filter, replacement, options, cancellationToken);

    ReplaceOneResult IMongoCollection<T>.ReplaceOne(
        FilterDefinition<T> filter,
        T replacement,
        UpdateOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.ReplaceOne(filter, replacement, options, cancellationToken);

    ReplaceOneResult IMongoCollection<T>.ReplaceOne(
        IClientSessionHandle session,
        FilterDefinition<T> filter,
        T replacement,
        ReplaceOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.ReplaceOne(session, filter, replacement, options, cancellationToken);

    ReplaceOneResult IMongoCollection<T>.ReplaceOne(
        IClientSessionHandle session,
        FilterDefinition<T> filter,
        T replacement,
        UpdateOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.ReplaceOne(session, filter, replacement, options, cancellationToken);

    Task<ReplaceOneResult> IMongoCollection<T>.ReplaceOneAsync(
        FilterDefinition<T> filter,
        T replacement,
        ReplaceOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.ReplaceOneAsync(filter, replacement, options, cancellationToken);

    Task<ReplaceOneResult> IMongoCollection<T>.ReplaceOneAsync(
        FilterDefinition<T> filter,
        T replacement,
        UpdateOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.ReplaceOneAsync(filter, replacement, options, cancellationToken);

    Task<ReplaceOneResult> IMongoCollection<T>.ReplaceOneAsync(
        IClientSessionHandle session,
        FilterDefinition<T> filter,
        T replacement,
        ReplaceOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.ReplaceOneAsync(session, filter, replacement, options, cancellationToken);

    Task<ReplaceOneResult> IMongoCollection<T>.ReplaceOneAsync(
        IClientSessionHandle session,
        FilterDefinition<T> filter,
        T replacement,
        UpdateOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.ReplaceOneAsync(session, filter, replacement, options, cancellationToken);

    UpdateResult IMongoCollection<T>.UpdateMany(
        FilterDefinition<T> filter,
        UpdateDefinition<T> update,
        UpdateOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.UpdateMany(filter, update, options, cancellationToken);

    UpdateResult IMongoCollection<T>.UpdateMany(
        IClientSessionHandle session,
        FilterDefinition<T> filter,
        UpdateDefinition<T> update,
        UpdateOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.UpdateMany(session, filter, update, options, cancellationToken);

    Task<UpdateResult> IMongoCollection<T>.UpdateManyAsync(
        FilterDefinition<T> filter,
        UpdateDefinition<T> update,
        UpdateOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.UpdateManyAsync(filter, update, options, cancellationToken);

    Task<UpdateResult> IMongoCollection<T>.UpdateManyAsync(
        IClientSessionHandle session,
        FilterDefinition<T> filter,
        UpdateDefinition<T> update,
        UpdateOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.UpdateManyAsync(session, filter, update, options, cancellationToken);

    UpdateResult IMongoCollection<T>.UpdateOne(
        FilterDefinition<T> filter,
        UpdateDefinition<T> update,
        UpdateOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.UpdateOne(filter, update, options, cancellationToken);

    UpdateResult IMongoCollection<T>.UpdateOne(
        IClientSessionHandle session,
        FilterDefinition<T> filter,
        UpdateDefinition<T> update,
        UpdateOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.UpdateOne(session, filter, update, options, cancellationToken);

    Task<UpdateResult> IMongoCollection<T>.UpdateOneAsync(
        FilterDefinition<T> filter,
        UpdateDefinition<T> update,
        UpdateOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.UpdateOneAsync(filter, update, options, cancellationToken);

    Task<UpdateResult> IMongoCollection<T>.UpdateOneAsync(
        IClientSessionHandle session,
        FilterDefinition<T> filter,
        UpdateDefinition<T> update,
        UpdateOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.UpdateOneAsync(session, filter, update, options, cancellationToken);

    IChangeStreamCursor<TResult> IMongoCollection<T>.Watch<TResult>(
        PipelineDefinition<ChangeStreamDocument<T>, TResult> pipeline,
        ChangeStreamOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.Watch(pipeline, options, cancellationToken);

    IChangeStreamCursor<TResult> IMongoCollection<T>.Watch<TResult>(
        IClientSessionHandle session,
        PipelineDefinition<ChangeStreamDocument<T>, TResult> pipeline,
        ChangeStreamOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.Watch(session, pipeline, options, cancellationToken);

    Task<IChangeStreamCursor<TResult>> IMongoCollection<T>.WatchAsync<TResult>(
        PipelineDefinition<ChangeStreamDocument<T>, TResult> pipeline,
        ChangeStreamOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.WatchAsync(pipeline, options, cancellationToken);

    Task<IChangeStreamCursor<TResult>> IMongoCollection<T>.WatchAsync<TResult>(
        IClientSessionHandle session,
        PipelineDefinition<ChangeStreamDocument<T>, TResult> pipeline,
        ChangeStreamOptions options,
        CancellationToken cancellationToken
    ) =>
        _collection.WatchAsync(session, pipeline, options, cancellationToken);

    IMongoCollection<T> IMongoCollection<T>.WithReadConcern(ReadConcern readConcern) =>
        _collection.WithReadConcern(readConcern);

    IMongoCollection<T> IMongoCollection<T>.WithReadPreference(ReadPreference readPreference) =>
        _collection.WithReadPreference(readPreference);

    IMongoCollection<T> IMongoCollection<T>.WithWriteConcern(WriteConcern writeConcern) =>
        _collection.WithWriteConcern(writeConcern);

    CollectionNamespace IMongoCollection<T>.CollectionNamespace => _collection.CollectionNamespace;

    IMongoDatabase IMongoCollection<T>.Database => _collection.Database;

    IBsonSerializer<T> IMongoCollection<T>.DocumentSerializer => _collection.DocumentSerializer;

    IMongoIndexManager<T> IMongoCollection<T>.Indexes => _collection.Indexes;

    IMongoSearchIndexManager IMongoCollection<T>.SearchIndexes => _collection.SearchIndexes;

    MongoCollectionSettings IMongoCollection<T>.Settings => _collection.Settings;
}
