using FluentResults;
using Mangarr.Stack.Conversion;
using ISource = Mangarr.Stack.Sources.ISource;
using PageList = Mangarr.Stack.Sources.Models.Page.PageList;
using PageListItem = Mangarr.Stack.Sources.Models.Page.PageListItem;

namespace Mangarr.Stack.Downloading;

public class PageDownloaderService
{
    public delegate Task ProcessCallbackDelegate(int progress);

    private readonly ConversionService _conversionService;

    public PageDownloaderService(ConversionService conversionService) => _conversionService = conversionService;

    public event ProcessCallbackDelegate? Progress;

    public async Task<Result<DownloadedPages>> DownloadPages(ISource source, PageList pageList)
    {
        List<DownloadedPage> pages = new();

        float total = pageList.Items.Count;

        for (int i = 0; i < pageList.Items.Count; i++)
        {
            PageListItem pageListItem = pageList.Items[i];
            Result<byte[]> getImageResult = await source.GetImage(pageListItem.Id);

            if (getImageResult.IsFailed)
            {
                pages.Add(new DownloadedPage(pageListItem, null, string.Empty, getImageResult.Reasons));
                goto Progress;
            }

            Result<byte[]> conversionResult = await _conversionService.Convert(getImageResult.Value);

            if (conversionResult.IsSuccess)
            {
                pages.Add(new DownloadedPage(pageListItem,
                    conversionResult.Value,
                    _conversionService.GetExtension(),
                    Array.Empty<IReason>()));
            }
            else
            {
                pages.Add(new DownloadedPage(pageListItem,
                    getImageResult.Value,
                    ".jpg",
                    conversionResult.Reasons));
            }

            await Task.Delay(100);

            Progress:
            int progress = (int)Math.Round(i / total * 100);
            Progress?.Invoke(progress);
        }

        return Result.Ok(new DownloadedPages(pages));
    }
}
