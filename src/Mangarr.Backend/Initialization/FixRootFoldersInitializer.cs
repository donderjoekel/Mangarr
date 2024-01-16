using Mangarr.Backend.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Mangarr.Backend.Initialization;

public class FixRootFoldersInitializer : IInitializer
{
    private readonly ExportOptions _exportOptions;
    private readonly IMongoCollection<RequestedMangaDocument> _requestedMangaCollection;
    private readonly IMongoCollection<RootFolderDocument> _rootFolderCollection;

    public FixRootFoldersInitializer(
        IMongoCollection<RootFolderDocument> rootFolderCollection,
        IMongoCollection<RequestedMangaDocument> requestedMangaCollection,
        IOptions<ExportOptions> exportOptions
    )
    {
        _rootFolderCollection = rootFolderCollection;
        _requestedMangaCollection = requestedMangaCollection;
        _exportOptions = exportOptions.Value;
    }

    public int Order { get; set; }

    async Task IInitializer.Initialize()
    {
        await CreateExportRootFolder();
        await FixMissingRootFolders();
    }

    private async Task CreateExportRootFolder()
    {
        long rootFolderCount = await _rootFolderCollection.CountDocumentsAsync(RootFolderDocument.Filter.Empty);
        if (rootFolderCount != 0)
        {
            return;
        }

        if (!string.IsNullOrEmpty(_exportOptions.Path))
        {
            await _rootFolderCollection.InsertOneAsync(new RootFolderDocument { Path = _exportOptions.Path });
        }
    }

    private async Task FixMissingRootFolders()
    {
        List<RootFolderDocument> rootFolderDocuments = await _rootFolderCollection.Find(x => true).ToListAsync();

        if (rootFolderDocuments.Count == 0)
        {
            return;
        }

        RootFolderDocument? rootFolderDocument = rootFolderDocuments.FirstOrDefault();

        if (rootFolderDocument == null)
        {
            return;
        }

        UpdateResult updateResult = await _requestedMangaCollection.UpdateManyAsync(RequestedMangaDocument.Filter.Or(
                RequestedMangaDocument.Filter.Eq(x => x.RootFolderId, string.Empty),
                RequestedMangaDocument.Filter.Eq(x => x.RootFolderId, null)),
            RequestedMangaDocument.Update.Set(x => x.RootFolderId, rootFolderDocument.Id));
    }
}
