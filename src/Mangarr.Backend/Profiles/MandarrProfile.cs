using AutoMapper;
using Mangarr.Shared.Models;
using Mangarr.Sources.Models.Search;
using ChapterProgressDocument = Mangarr.Backend.Database.Documents.ChapterProgressDocument;
using RequestedChapterDocument = Mangarr.Backend.Database.Documents.RequestedChapterDocument;
using RequestedMangaDocument = Mangarr.Backend.Database.Documents.RequestedMangaDocument;

namespace Mangarr.Backend.Profiles;

public class MangarrProfile : Profile
{
    public MangarrProfile()
    {
        CreateMap<RequestedMangaDocument, RequestedMangaModel>();
        CreateMap<ChapterProgressDocument, ChapterProgressModel>();
        CreateMap<SourceDocument, ProviderModel>();
        CreateMap<SearchResultItem, ProviderMangaModel>();
        CreateMap<RequestedChapterDocument, MangaChapterModel>();
    }
}
