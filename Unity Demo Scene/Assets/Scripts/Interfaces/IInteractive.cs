/// <summary>
/// Interface for interactive items
/// </summary>
public interface IInteractive
{
    string DisplayText { get; }
    void InteractWith();
    void HoldInteractive(bool selected);
}
