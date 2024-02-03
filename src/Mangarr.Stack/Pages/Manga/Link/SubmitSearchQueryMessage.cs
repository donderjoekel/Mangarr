using Mangarr.Stack.Messaging;

namespace Mangarr.Stack.Pages.Manga.Link;

public readonly struct SubmitSearchQueryMessage : IMessageBusMessage
{
    public readonly string Query;

    public SubmitSearchQueryMessage(string query) => Query = query;
}
