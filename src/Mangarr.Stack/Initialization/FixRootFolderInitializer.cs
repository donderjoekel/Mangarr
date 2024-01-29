using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Database.Repositories;
using Mangarr.Stack.Exporting;
using Microsoft.Extensions.Options;

namespace Mangarr.Stack.Initialization;

public class FixRootFolderInitializer : IInitializable
{
    private readonly ExportOptions _options;
    private readonly RequestedMangaRepository _requestedMangaRepository;
    private readonly RootFolderRepository _rootFolderRepository;

    public FixRootFolderInitializer(
        RequestedMangaRepository requestedMangaRepository,
        RootFolderRepository rootFolderRepository,
        IOptions<ExportOptions> options
    )
    {
        _requestedMangaRepository = requestedMangaRepository;
        _rootFolderRepository = rootFolderRepository;
        _options = options.Value;
    }

    public int Order => 0;

    public async Task Initialize()
    {
        await CreateExportRootFolder();
        await FixMissingRootFolders();
    }

    private async Task CreateExportRootFolder()
    {
        if (_rootFolderRepository.Any())
        {
            return;
        }

        if (!string.IsNullOrEmpty(_options.Path))
        {
            await _rootFolderRepository.AddAsync(new RootFolderDocument
            {
                Version = RootFolderDocument.CurrentVersion, Path = _options.Path
            });
        }
    }

    private async Task FixMissingRootFolders()
    {
        if (!_rootFolderRepository.Any())
        {
            return;
        }

        RootFolderDocument rootFolderDocument = _rootFolderRepository.First();

        List<RequestedMangaDocument> missingRootFolders =
            _requestedMangaRepository.Where(x => string.IsNullOrEmpty(x.RootFolderId)).ToList();

        foreach (RequestedMangaDocument requestedMangaDocument in missingRootFolders)
        {
            requestedMangaDocument.RootFolderId = rootFolderDocument.Id;
            await _requestedMangaRepository.UpdateAsync(requestedMangaDocument);
        }
    }
}
