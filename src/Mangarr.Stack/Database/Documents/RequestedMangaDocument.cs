using System.ComponentModel;
using MongoDB.Bson.Serialization.Attributes;

namespace Mangarr.Stack.Database.Documents;

public class RequestedMangaDocument : DocumentBase<RequestedMangaDocument>, ISupportInitialize
{
    public const int CurrentVersion = 1;

    // ReSharper disable once FieldCanBeMadeReadOnly.Local
    [BsonExtraElements] private Dictionary<string, object>? _extraElements;

    public required int SearchId { get; set; }
    public required string SourceId { get; set; } = null!;
    public required string MangaId { get; set; } = null!;
    public required string RootFolderId { get; set; } = null!;
    public required bool NewChaptersOnly { get; set; }
    public required bool Monitor { get; set; }
    public DateTime? LastScanDate { get; set; }
    public bool Deleted { get; set; }

    void ISupportInitialize.BeginInit()
    {
        // Left empty on purpose
    }

    void ISupportInitialize.EndInit()
    {
        if (_extraElements == null)
        {
            return;
        }

        if (!_extraElements.TryGetValue("CreationDate", out object? creationDate))
        {
            return;
        }

        DateCreated = (DateTime)creationDate;
        _extraElements.Remove("CreationDate");
    }
}
