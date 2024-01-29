namespace Mangarr.Stack.Database.Documents;

public class RootFolderDocument : DocumentBase<RootFolderDocument>
{
    public const int CurrentVersion = 1;
    public string Path { get; set; } = null!;
}
