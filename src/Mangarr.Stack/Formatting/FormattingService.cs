using Mangarr.Stack.AniList;
using Mangarr.Stack.Database.Documents;
using Mangarr.Stack.Extensions;
using Mangarr.Stack.Settings;

namespace Mangarr.Stack.Formatting;

public class FormattingService
{
    private readonly AniListApi _aniListApi;
    private readonly SettingsApi _settingsApi;

    public FormattingService(SettingsApi settingsApi, AniListApi aniListApi)
    {
        _settingsApi = settingsApi;
        _aniListApi = aniListApi;
    }

    public string FormatDirectory(RequestedMangaDocument requestedMangaDocument)
    {
        string formatted = _aniListApi.GetPreferredTitle(requestedMangaDocument);

        formatted = formatted.ReplaceAll(_settingsApi.Formatting.InvalidCharacterReplacement,
            Path.GetInvalidPathChars().Select(x => x.ToString()));

        formatted = formatted.ReplaceAll(_settingsApi.Formatting.InvalidCharacterReplacement,
            Path.GetInvalidFileNameChars().Select(x => x.ToString()));

        return formatted;
    }

    public string FormatFilename(
        RequestedMangaDocument requestedMangaDocument,
        RequestedChapterDocument requestedChapterDocument
    )
    {
        string formatted = _settingsApi.Formatting.Format;

        formatted = formatted.Replace("{mangaTitle}", _aniListApi.GetPreferredTitle(requestedMangaDocument));
        formatted = formatted.Replace("{chapterTitle}", requestedChapterDocument.ChapterName);
        formatted = formatted.Replace("{chapterNumber}", requestedChapterDocument.ChapterNumber.ToString());

        formatted = formatted.ReplaceAll(string.Empty,
            _settingsApi.Formatting.Strip?.Split(" ", StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>());

        formatted = formatted.ReplaceAll(_settingsApi.Formatting.InvalidCharacterReplacement,
            Path.GetInvalidPathChars().Select(x => x.ToString()));

        formatted = formatted.ReplaceAll(_settingsApi.Formatting.InvalidCharacterReplacement,
            Path.GetInvalidFileNameChars().Select(x => x.ToString()));

        return formatted;
    }
}
