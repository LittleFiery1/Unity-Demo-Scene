/// <summary>
/// Interface for interactive items
/// </summary>
public interface IInteractive
{
    //For what text is displayed when an object is looked at.
    string DisplayText { get; }
    //For what happens when an object is clicked on.
    void InteractWith();
    //For what happens if an object is clicked and held.
    void HoldInteractive(bool selected);
}
