using FluentResults;
using ISource = Mangarr.Backend.Sources.ISource;
using PageList = Mangarr.Backend.Sources.Models.Page.PageList;
using PageListItem = Mangarr.Backend.Sources.Models.Page.PageListItem;

namespace Mangarr.Backend.Services;

public class PageDownloaderService
{
    public async Task<Result<List<byte[]>>> DownloadPages(
        ISource source,
        PageList pageList,
        Func<int, Task>? progressCallback = null
    )
    {
        List<byte[]> pages = new();
        List<IReason> reasons = new();

        float total = pageList.Items.Count;

        for (int i = 0; i < pageList.Items.Count; i++)
        {
            PageListItem pageListItem = pageList.Items[i];
            Result<byte[]> pageResult = await source.GetImage(pageListItem.Id);

            if (pageResult.IsSuccess)
            {
                pages.Add(pageResult.Value);
            }
            else
            {
                reasons.AddRange(pageResult.Reasons);
            }

            await Task.Delay(100);

            if (progressCallback == null)
            {
                continue;
            }

            int progress = (int)Math.Round(i / total * 100);
            await progressCallback(progress);
        }

        return reasons.Count == 0
            ? Result.Ok(pages)
            : Result.Ok().WithReasons(reasons);
    }
}
