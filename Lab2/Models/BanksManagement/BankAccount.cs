using System;

namespace Lab2.Models.BanksManagement
{
    // The BankAccount class serves as a base class for different types of bank accounts.
    // It follows the Liskov Substitution Principle (LSP) by ensuring that derived classes can substitute the base class without altering the correctness of the program.
    public class BankAccount
    {
        // Balance of the bank account, protected so that derived classes can access it.
        public double m_balance { get; protected set; } 

        // Constructor: Initializes the bank account with a given balance.
        public BankAccount(double balance)
        {
            m_balance = balance;
        }

        // Virtual method for depositing money into the account.
        // Ensures that deposits are always positive.
        public virtual void Deposit(double amount)
        {
            if (amount > 0)
            {
                m_balance += amount;
                Console.WriteLine($"Deposited ${amount}. New Balance: ${m_balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        // Virtual method for withdrawing money from the account.
        // Ensures that withdrawals do not exceed the available balance.
        public virtual void Withdraw(double amount)
        {
            if (amount > 0 && m_balance >= amount)
            {
                m_balance -= amount;
                Console.WriteLine($"Withdrew ${amount}. New Balance: ${m_balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
    }
}
