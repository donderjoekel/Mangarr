using AutoMapper;
using Mangarr.Shared.Models;
using ChapterProgressDocument = Mangarr.Backend.Database.Documents.ChapterProgressDocument;
using RequestedChapterDocument = Mangarr.Backend.Database.Documents.RequestedChapterDocument;
using RequestedMangaDocument = Mangarr.Backend.Database.Documents.RequestedMangaDocument;
using SearchResultItem = Mangarr.Backend.Sources.Models.Search.SearchResultItem;

namespace Mangarr.Backend.Profiles;

public class MangarrProfile : Profile
{
    public MangarrProfile()
    {
        CreateMap<RequestedMangaDocument, RequestedMangaModel>();
        CreateMap<ChapterProgressDocument, ChapterProgressModel>();
        CreateMap<SourceDocument, ProviderModel>();
        CreateMap<SearchResultItem, ProviderMangaModel>();
    }
}
