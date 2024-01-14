namespace Mangarr.Backend.Initialization;

public interface IInitializer
{
    int Order { get; }
    Task Initialize();
}
