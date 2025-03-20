/// <summary>
/// Interface for defining eating behavior.
/// This follows ISP by ensuring that only classes that actually eat implement this.
/// </summary>
public interface IEat
{
    /// <summary>
    /// Simulate eating activity.
    /// </summary>
    void Eat();
}
