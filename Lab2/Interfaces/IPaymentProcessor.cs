/// <summary>
/// Interface for processing payments.
/// This follows Dependency Inversion Principle (DIP) by abstracting payment processing
/// so that high-level modules (OrderProcessor) do not depend on concrete payment implementations.
/// </summary>
public interface IPaymentProcessor
{
    /// <summary>
    /// Processes a payment of the given amount.
    /// </summary>
    /// <param name="amount">Amount to process</param>
    void ProcessPayment(decimal amount);
}
