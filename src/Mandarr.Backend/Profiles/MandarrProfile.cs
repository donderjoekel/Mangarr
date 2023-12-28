using AutoMapper;
using Mandarr.Backend.Database.Documents;
using Mandarr.Shared.Models;
using Mandarr.Sources.Models.Search;

namespace Mandarr.Backend.Profiles;

public class MandarrProfile : Profile
{
    public MandarrProfile()
    {
        CreateMap<RequestedMangaDocument, RequestedMangaModel>();
        CreateMap<ChapterProgressDocument, ChapterProgressModel>();
        CreateMap<ProviderDocument, ProviderModel>();
        CreateMap<SearchResultItem, ProviderMangaModel>();
        CreateMap<RequestedChapterDocument, MangaChapterModel>();
    }
}
