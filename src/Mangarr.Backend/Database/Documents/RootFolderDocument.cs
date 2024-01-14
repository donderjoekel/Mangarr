namespace Mangarr.Backend.Database.Documents;

public class RootFolderDocument : DocumentBase<RootFolderDocument>
{
    public string Path { get; set; } = null!;
}
