using System;

/// <summary>
/// Processes an order using a specified payment processor.
/// This follows DIP by depending on the IPaymentProcessor abstraction rather than specific implementations.
/// </summary>
public class OrderProcessor
{
    private readonly IPaymentProcessor _paymentProcessor;

    /// <summary>
    /// Injects a payment processor dependency.
    /// This allows OrderProcessor to work with any payment processor without modification.
    /// </summary>
    public OrderProcessor(IPaymentProcessor paymentProcessor)
    {
        _paymentProcessor = paymentProcessor;
    }

    /// <summary>
    /// Processes an order using the specified payment method.
    /// This follows DIP by using an abstraction to handle payment processing.
    /// </summary>
    public void ProcessOrder(decimal amount)
    {
        Console.WriteLine("Processing order...");
        _paymentProcessor.ProcessPayment(amount);
        Console.WriteLine("Order processed successfully!\n");
    }
}
