using Mangarr.Stack.Database.Documents;
using MongoDB.Driver;

namespace Mangarr.Stack.Database.Repositories;

public class ChapterProgressRepository : RepositoryBase<ChapterProgressDocument>
{
    public ChapterProgressRepository(IMongoCollection<ChapterProgressDocument> collection)
        : base(collection)
    {
    }

    public ChapterProgressDocument? GetByChapterId(string chapterId) =>
        this.FirstOrDefault(x => x.ChapterId == chapterId);

    public IEnumerable<ChapterProgressDocument> GetByMangaId(string mangaId) => this.Where(x => x.MangaId == mangaId);
}
