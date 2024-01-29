namespace Mangarr.Stack.Database.Documents;

public class MangaMetadataDocument : DocumentBase<MangaMetadataDocument>
{
    public const int CurrentVersion = 1;
    public string MangaId { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string? TitleEnglish { get; set; } = string.Empty;
    public string? TitleRomaji { get; set; } = string.Empty;
    public string? TitleNative { get; set; } = string.Empty;
    public string? DescriptionHtml { get; set; } = string.Empty;
    public string? DescriptionMd { get; set; } = string.Empty;
    public string? CoverUrl { get; set; } = string.Empty;
    public string? BannerUrl { get; set; } = string.Empty;
    public string[] Genres { get; set; } = Array.Empty<string>();
    public string[] Tags { get; set; } = Array.Empty<string>();
}
