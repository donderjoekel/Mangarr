namespace Mangarr.Backend.Sources.Models.Chapter;

public record ChapterListItem(string Id, string Name, double Number, DateTime Date, string Url, int Volume = 1);
