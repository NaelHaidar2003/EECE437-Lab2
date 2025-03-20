/// <summary>
/// Interface for defining work-related behavior.
/// This follows the Interface Segregation Principle (ISP)
/// by ensuring that only classes that need "Work" behavior implement this.
/// </summary>
public interface IWork
{
    /// <summary>
    /// Perform work-related activities.
    /// </summary>
    void Work();
}
