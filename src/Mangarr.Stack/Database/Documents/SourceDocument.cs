namespace Mangarr.Stack.Database.Documents;

public class SourceDocument : DocumentBase<SourceDocument>
{
    public const int CurrentVersion = 1;
    public required string Identifier { get; set; }
    public required string Name { get; set; }
    public required string Url { get; set; }
    public bool Enabled { get; set; } = false;
}
