namespace Mangarr.Stack.Initialization;

public interface IInitializable
{
    int Order { get; }
    Task Initialize();
}
