using System;
using Lab2.Models.LibraryManagement;
using Lab2.Models.ProductManagement;
using Lab2.Models.BanksManagement;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create an inventory manager
        InventoryManager inventory = new InventoryManager();

        // Add books to inventory
        Book book1 = new Book("1984", "George Orwell", "Secker & Warburg");
        Book book2 = new Book("Brave New World", "Aldous Huxley", "Chatto & Windus");
        Book book3 = new Book("Animal Farm", "George Orwell", "Secker & Warburg");

        inventory.AddBook(book1);
        inventory.AddBook(book2);
        inventory.AddBook(book3);

        // Create a report generator
        ReportGenerator reportGenerator = new ReportGenerator();

        Console.WriteLine("Part (i)");
        // List all books
        Console.WriteLine("📚 All Books in Inventory:");
        inventory.ListBooks();
        Console.WriteLine();

        // Show books by a specific author
        Console.WriteLine("📖 Books by George Orwell:");
        reportGenerator.booksByAuthor("George Orwell", inventory.GetBooks());
        Console.WriteLine();

        // Find author with most books
        Console.WriteLine("🏆 Author with Most Books:");
        reportGenerator.authorWithMostBooks(inventory.GetBooks());

        Console.WriteLine("\nPart (ii)");
        Product laptop = new Electronics("Gaming Laptop", 2.0);
        Product tShirt = new Clothing("T-Shirt", 1.0);
        Product sofa = new Furniture("Sofa", 20.0);

        // Print shipping costs
        Console.WriteLine($"Shipping cost for {laptop.m_name}: ${laptop.calculateShippingCost()}");
        Console.WriteLine($"Shipping cost for {tShirt.m_name}: ${tShirt.calculateShippingCost()}");
        Console.WriteLine($"Shipping cost for {sofa.m_name}: ${sofa.calculateShippingCost()}");

        Console.WriteLine("\nPart (iii)");
        BankAccount basicAccount = new BankAccount(300);
        SavingsAccount savings = new SavingsAccount(500);
        CheckingAccount checking = new CheckingAccount(500);

        Console.WriteLine("\n--- Testing Basic BankAccount ---");
        basicAccount.Deposit(50);
        basicAccount.Withdraw(100);
        basicAccount.Withdraw(500); // Should fail

        Console.WriteLine("\n--- Testing Savings Account ---");
        savings.Deposit(5);  // Should reject
        savings.Deposit(50); // Should work
        savings.Withdraw(250); // Should reject
        savings.Withdraw(100); // Should work

        Console.WriteLine("\n--- Testing Checking Account ---");
        checking.Deposit(20); // Should work
        checking.Withdraw(490); // Should work with $1 fee
        checking.Withdraw(40); // Should reject (not enough funds)

        Console.WriteLine("\nPart (iv)");
        HumanWorker human = new HumanWorker();
        RobotWorker robot = new RobotWorker();

        Console.WriteLine("Human Worker:");
        human.Work();
        human.Eat();
        human.Sleep();

        Console.WriteLine("\nRobot Worker:");
        robot.Work();
    }
}
