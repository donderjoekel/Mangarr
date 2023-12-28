namespace Mangarr.Sources.Cloudflare;

public static class MessageHandlerExtensions
{
    public static HttpMessageHandler GetMostInnerHandler(this HttpMessageHandler self) =>
        self is DelegatingHandler handler
            ? handler.InnerHandler.GetMostInnerHandler()
            : self;
}
