namespace Mangarr.Stack.Messaging;

public interface ISubscriptionToken
{
    Guid Id { get; }
    Type MessageType { get; }
}
