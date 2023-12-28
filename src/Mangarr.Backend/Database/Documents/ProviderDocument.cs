namespace Mangarr.Backend.Database.Documents;

public class ProviderDocument : DocumentBase<ProviderDocument>
{
    public required string Identifier { get; set; }
    public required string Name { get; set; }
    public required string Url { get; set; }
    public bool Enabled { get; set; } = false;
}
