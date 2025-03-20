using System;

/// <summary>
/// A concrete implementation of IPaymentProcessor for PayPal payments.
/// This follows DIP by implementing an abstraction instead of being directly referenced in OrderProcessor.
/// </summary>
public class PayPalProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        // Simulating PayPal transaction processing
        Console.WriteLine($"Connecting to PayPal...");
        Console.WriteLine($"Processing PayPal payment of ${amount}...");
        Console.WriteLine("Payment successful!");
    }
}
