namespace Mangarr.Stack.Messaging.Implementation;

internal class BasicSubscriptionToken : ISubscriptionToken
{
    public BasicSubscriptionToken(Guid id, Type type)
    {
        Id = id;
        MessageType = type;
    }

    public Guid Id { get; }
    public Type MessageType { get; }
}
