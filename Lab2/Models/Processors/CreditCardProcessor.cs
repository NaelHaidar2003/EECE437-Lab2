using System;

/// <summary>
/// A concrete implementation of IPaymentProcessor for credit card payments.
/// This follows DIP by implementing an abstraction instead of being directly referenced in OrderProcessor.
/// </summary>
public class CreditCardProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        // Simulating credit card transaction processing
        Console.WriteLine($"Connecting to credit card gateway...");
        Console.WriteLine($"Processing credit card payment of ${amount}...");
        Console.WriteLine("Transaction approved!");
    }
}
