using AutoMapper;
using Mangarr.Backend.Database.Documents;
using Mangarr.Shared.Models;
using Mangarr.Sources.Models.Search;

namespace Mangarr.Backend.Profiles;

public class MangarrProfile : Profile
{
    public MangarrProfile()
    {
        CreateMap<RequestedMangaDocument, RequestedMangaModel>();
        CreateMap<ChapterProgressDocument, ChapterProgressModel>();
        CreateMap<ProviderDocument, ProviderModel>();
        CreateMap<SearchResultItem, ProviderMangaModel>();
        CreateMap<RequestedChapterDocument, MangaChapterModel>();
    }
}
