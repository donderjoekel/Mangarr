using System.ComponentModel;
using MongoDB.Bson.Serialization.Attributes;

namespace Mangarr.Stack.Database.Documents;

public class RequestedChapterDocument : DocumentBase<RequestedChapterDocument>, ISupportInitialize
{
    public const int CurrentVersion = 1;

    // ReSharper disable once FieldCanBeMadeReadOnly.Local
    [BsonExtraElements] private Dictionary<string, object>? _extraElements;

    public required string RequestedMangaId { get; set; }
    public required string ChapterId { get; set; } = null!;
    public required string ChapterName { get; set; } = null!;
    public required double ChapterNumber { get; set; }
    public required int VolumeNumber { get; set; }
    public required DateTime ReleaseDate { get; set; }
    public required bool MarkedForDownload { get; set; }
    public bool Downloaded { get; set; }
    public DateTime? DateDownloaded { get; set; }

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
