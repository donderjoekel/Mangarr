namespace Mandarr.Shared.Requests;

public class MangaSearchRequest
{
    public string Query { get; init; } = default!;
    public int Page { get; init; } = 1;
}
