using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace Mangarr.Backend.Database.Documents;

public class DocumentBase<T> where T : DocumentBase<T>
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = null!;

    public static FilterDefinitionBuilder<T> Filter => Builders<T>.Filter;
    public static UpdateDefinitionBuilder<T> Update => Builders<T>.Update;
}
