using System;

/// <summary>
/// Represents a robot worker who only works.
/// ISP is followed because the robot does NOT implement unnecessary interfaces (`IEat`, `ISleep`).
/// </summary>
public class RobotWorker : IWork
{
    /// <summary>
    /// Simulate work being done by a robot.
    /// ISP: Since robots do not eat or sleep, this class ONLY implements `IWork`.
    /// </summary>
    public void Work()
    {
        Console.WriteLine("Robot is assembling parts in the factory...");
    }
}
