namespace Mangarr.Stack.Messaging;

public interface IMessageBus
{
    delegate void MessageReceivedDelegate<in TMessage>(TMessage message) where TMessage : IMessageBusMessage;

    ISubscriptionToken Subscribe<TMessage>(MessageReceivedDelegate<TMessage> handler)
        where TMessage : IMessageBusMessage;

    ISubscriptionToken Subscribe<TMessage>(IMessageReceiver<TMessage> receiver)
        where TMessage : IMessageBusMessage;

    void Unsubscribe(ISubscriptionToken token);

    void Publish<TMessage>(TMessage message) where TMessage : IMessageBusMessage;
}
