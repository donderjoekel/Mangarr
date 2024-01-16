using FluentResults;
using Mangarr.Backend.Sources.Models.Page;

namespace Mangarr.Backend.Downloading;

public record DownloadedPage(
    PageListItem PageListItem,
    byte[]? Data,
    string Extension,
    IEnumerable<IReason> Reasons
)
{
    public bool Downloaded => Data != null;
}
