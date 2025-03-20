using System;

/// <summary>
/// Represents a human worker who can work, eat, and sleep.
/// This class implements three separate interfaces to adhere to ISP.
/// </summary>
public class HumanWorker : IWork, IEat, ISleep
{
    /// <summary>
    /// Simulate work being done by a human.
    /// ISP: This method is in its own interface (`IWork`), so other classes
    /// that do not need it (e.g., machines) are not forced to implement it.
    /// </summary>
    public void Work()
    {
        Console.WriteLine("Human is analyzing reports and writing documentation...");
    }

    /// <summary>
    /// Simulate eating behavior for a human.
    /// ISP: This is separated into `IEat`, ensuring that only classes needing this feature implement it.
    /// </summary>
    public void Eat()
    {
        Console.WriteLine("Human is having lunch in the cafeteria...");
    }

    /// <summary>
    /// Simulate sleeping behavior for a human.
    /// ISP: `ISleep` ensures that classes that don’t sleep (e.g., robots) don’t need to implement this.
    /// </summary>
    public void Sleep()
    {
        Console.WriteLine("Human is sleeping to recover energy...");
    }
}
