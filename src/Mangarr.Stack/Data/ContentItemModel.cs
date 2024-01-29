using Mangarr.Stack.Database.Documents;

namespace Mangarr.Stack.Data;

public record ContentItemModel(
    RequestedMangaDocument Manga,
    MangaMetadataDocument Metadata,
    List<RequestedChapterDocument> Chapters,
    SourceDocument? Source
);
