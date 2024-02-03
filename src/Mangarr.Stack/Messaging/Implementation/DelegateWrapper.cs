namespace Mangarr.Stack.Messaging.Implementation;

internal abstract class DelegateWrapper
{
    public abstract ISubscriptionToken Token { get; }

    public abstract void Invoke(IMessageBusMessage message);
}

internal class DelegateWrapper<TMessage> : DelegateWrapper
    where TMessage : IMessageBusMessage
{
    private readonly IMessageBus.MessageReceivedDelegate<TMessage> _handler;

    public override ISubscriptionToken Token { get; }

    public DelegateWrapper(IMessageBus.MessageReceivedDelegate<TMessage> handler, ISubscriptionToken token)
    {
        _handler = handler;
        Token = token;
    }

    public override void Invoke(IMessageBusMessage message) => _handler((TMessage)message);
}
