namespace Mangarr.Stack.Messaging.Implementation;

internal class BasicMessageBus : IMessageBus
{
    private readonly Dictionary<Type, List<DelegateWrapper>> _delegateHandlers = new();
    private readonly Dictionary<Type, List<ReflectiveHandler>> _reflectiveHandlers = new();

    public ISubscriptionToken Subscribe<TMessage>(IMessageBus.MessageReceivedDelegate<TMessage> handler)
        where TMessage : IMessageBusMessage
    {
        Type messageType = typeof(TMessage);
        BasicSubscriptionToken token = new(Guid.NewGuid(), messageType);
        DelegateWrapper<TMessage> delegateWrapper = new(handler, token);
        _delegateHandlers.TryAdd(messageType, new List<DelegateWrapper>());
        _delegateHandlers[messageType].Add(delegateWrapper);
        return token;
    }

    public ISubscriptionToken Subscribe<TMessage>(IMessageReceiver<TMessage> receiver)
        where TMessage : IMessageBusMessage
    {
        Type messageType = typeof(TMessage);
        BasicSubscriptionToken token = new(Guid.NewGuid(), messageType);
        ReflectiveHandler reflectiveHandler = new(token, receiver, messageType);
        _reflectiveHandlers.TryAdd(messageType, new List<ReflectiveHandler>());
        _reflectiveHandlers[messageType].Add(reflectiveHandler);
        return token;
    }

    public void Unsubscribe(ISubscriptionToken token)
    {
        if (_delegateHandlers.TryGetValue(token.MessageType, out List<DelegateWrapper>? delegateWrappers))
        {
            delegateWrappers.RemoveAll(wrapper => wrapper.Token.Id == token.Id);
        }

        if (_reflectiveHandlers.TryGetValue(token.MessageType, out List<ReflectiveHandler>? reflectiveHandlers))
        {
            reflectiveHandlers.RemoveAll(handler => handler.SubscriptionToken.Id == token.Id);
        }
    }

    public void Publish<TMessage>(TMessage message) where TMessage : IMessageBusMessage
    {
        Type messageType = typeof(TMessage);

        PublishDelegates(message, messageType);
        PublishHandlers(message, messageType);
    }

    private void PublishDelegates<TMessage>(TMessage message, Type messageType) where TMessage : IMessageBusMessage
    {
        if (!_delegateHandlers.TryGetValue(messageType, out List<DelegateWrapper>? delegateWrappers))
        {
            return;
        }

        List<DelegateWrapper> copy = new(delegateWrappers);
        foreach (DelegateWrapper delegateWrapper in copy)
        {
            delegateWrapper.Invoke(message);
        }
    }

    private void PublishHandlers<TMessage>(TMessage message, Type messageType) where TMessage : IMessageBusMessage
    {
        if (!_reflectiveHandlers.TryGetValue(messageType, out List<ReflectiveHandler>? reflectiveHandlers))
        {
            return;
        }

        List<ReflectiveHandler> copy = new(reflectiveHandlers);
        foreach (ReflectiveHandler reflectiveHandler in copy)
        {
            reflectiveHandler.HandleMessage(message);
        }
    }
}
