namespace Mangarr.Stack.Messaging;

public interface IMessageReceiver<in TMessage> where TMessage : IMessageBusMessage
{
    void Receive(TMessage message);
}
