/// <summary>
/// Interface for defining sleeping behavior.
/// ISP is applied by ensuring that only classes needing sleep implement this.
/// </summary>
public interface ISleep
{
    /// <summary>
    /// Simulate sleeping activity.
    /// </summary>
    void Sleep();
}
