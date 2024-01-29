using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace Mangarr.Stack.Database.Documents;

public class DocumentBase<T> where T : DocumentBase<T>
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = null!;

    public required int Version { get; set; }

    public static FilterDefinitionBuilder<T> Filter => Builders<T>.Filter;
    public static UpdateDefinitionBuilder<T> Update => Builders<T>.Update;
}
