using System;

public class HumanWorker : IWork, IEat, ISleep
{
    public void Work()
    {
        Console.WriteLine("Human is working...");
    }

    public void Eat()
    {
        Console.WriteLine("Human is eating...");
    }

    public void Sleep()
    {
        Console.WriteLine("Human is sleeping...");
    }
}
