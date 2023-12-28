using FluentResults;
using Mandarr.Sources;
using Mandarr.Sources.Models.Page;

namespace Mandarr.Backend.Services;

public class PageDownloaderService
{
    public async Task<Result<List<byte[]>>> DownloadPages(
        ISource source,
        PageList pageList,
        Func<int, Task>? progressCallback = null
    )
    {
        List<byte[]> pages = [];
        List<IError> errors = [];

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
                errors.AddRange(pageResult.Errors);
            }

            await Task.Delay(100);

            if (progressCallback == null)
            {
                continue;
            }

            int progress = (int)Math.Round(i / total * 100);
            await progressCallback(progress);
        }

        return errors.Count == 0
            ? Result.Ok(pages)
            : Result.Fail(errors);
    }
}
