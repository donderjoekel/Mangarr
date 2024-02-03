using System.Reflection;

namespace Mangarr.Stack.Messaging.Implementation;

internal class ReflectiveHandler
{
    private readonly object _instance;
    private readonly MethodInfo _method;

    public BasicSubscriptionToken SubscriptionToken { get; private set; }

    public ReflectiveHandler(BasicSubscriptionToken subscriptionToken, object handler, Type messageType)
    {
        _instance = handler;
        _method = GetImplicitMethod(handler, messageType) ??
                  GetExplicitMethod(handler, messageType) ??
                  throw new InvalidOperationException("No valid implementation can be found");

        SubscriptionToken = subscriptionToken;
    }

    private static MethodInfo? GetImplicitMethod(object handler, Type messageType) =>
        handler.GetType()
            .GetMethod("Receive",
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                null,
                new[] { messageType },
                null);

    private static MethodInfo? GetExplicitMethod(object handler, Type messageType) =>
        typeof(IMessageReceiver<>)
            .MakeGenericType(messageType)
            .GetMethod("Receive",
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                null,
                new[] { messageType },
                null);

    public void HandleMessage<TMessage>(TMessage message)
        where TMessage : IMessageBusMessage
        => _method.Invoke(_instance, new object[] { message });
}
