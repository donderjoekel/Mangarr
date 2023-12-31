namespace Mangarr.Backend.Sources.Caching;

public class CachedResponseMessage
{
    public HttpResponseMessage ResponseMessage { get; set; }
    public byte[]? Content { get; set; }

    public CachedResponseMessage(HttpResponseMessage responseMessage) => ResponseMessage = responseMessage;

    public async Task SaveContent()
    {
        // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
        if (ResponseMessage.Content == null)
        {
            return;
        }

        Content = await ResponseMessage.Content.ReadAsByteArrayAsync();
    }

    public HttpResponseMessage ToHttpResponseMessage()
    {
        if (Content != null)
        {
            ResponseMessage.Content = new ByteArrayContent(Content);
        }

        return ResponseMessage;
    }
}
