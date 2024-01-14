using System.Net;
using Mangarr.Shared.Requests;
using Mangarr.Shared.Responses;
using MongoDB.Driver;

namespace Mangarr.Backend.Endpoints.Folder.Add;

public class FolderAddEndpoint : Endpoint<FolderAddRequest, FolderAddResponse>
{
    private readonly IMongoCollection<RootFolderDocument> _rootFolderCollection;

    public FolderAddEndpoint(IMongoCollection<RootFolderDocument> rootFolderCollection) =>
        _rootFolderCollection = rootFolderCollection;

    public override void Configure()
    {
        Post("folder/add");
        AllowAnonymous();
    }

    public override async Task HandleAsync(FolderAddRequest req, CancellationToken ct)
    {
        if (!Directory.Exists(req.Path))
        {
            await SendAsync(null, (int)HttpStatusCode.BadRequest, ct);
            return;
        }

        bool folderExists = await _rootFolderCollection
            .Find(x => string.Equals(x.Path, req.Path, StringComparison.InvariantCultureIgnoreCase))
            .AnyAsync(ct);

        if (folderExists)
        {
            await SendAsync(null, (int)HttpStatusCode.Conflict, ct);
            return;
        }

        await _rootFolderCollection.InsertOneAsync(new RootFolderDocument { Path = req.Path }, cancellationToken: ct);
        await SendOkAsync(ct);
    }
}
