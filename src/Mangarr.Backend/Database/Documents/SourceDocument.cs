namespace Mangarr.Backend.Database.Documents;

public class SourceDocument : DocumentBase<SourceDocument>
{
    public required string Identifier { get; set; }
    public required string Name { get; set; }
    public required string Url { get; set; }
    public bool Enabled { get; set; } = false;
}
