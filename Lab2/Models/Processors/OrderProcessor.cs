using System;

public class OrderProcessor
{
    private readonly IPaymentProcessor _paymentProcessor;

    public OrderProcessor(IPaymentProcessor paymentProcessor)
    {
        _paymentProcessor = paymentProcessor;
    }

    public void ProcessOrder(decimal amount)
    {
        Console.WriteLine("Processing order...");
        _paymentProcessor.ProcessPayment(amount);
        Console.WriteLine("Order processed successfully!");
    }
}
