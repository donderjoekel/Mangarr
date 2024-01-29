using FluentResults;
using Mangarr.Stack.Sources.Models.Page;

namespace Mangarr.Stack.Downloading;

public record DownloadedPage(
    PageListItem PageListItem,
    byte[]? Data,
    string Extension,
    IEnumerable<IReason> Reasons
)
{
    public bool Downloaded => Data != null;
}
