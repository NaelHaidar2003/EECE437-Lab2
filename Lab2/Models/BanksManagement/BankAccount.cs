using System;

namespace Lab2.Models.BanksManagement
{
    public class BankAccount
    {
        public double m_balance { get; protected set; } 

        public BankAccount(double balance)
        {
            m_balance = balance;
        }

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
