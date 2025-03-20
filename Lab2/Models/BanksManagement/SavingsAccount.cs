namespace Lab2.Models.BanksManagement
{
    // The SavingsAccount class inherits from the BankAccount base class.
    // It represents a savings account with specific deposit and withdrawal restrictions.
    public class SavingsAccount : BankAccount
    {
        // Constructor: Calls the base class constructor to initialize the balance.
        public SavingsAccount(double balance) : base(balance)
        {
        }

        // Overrides the Deposit method to enforce a minimum deposit amount of $10.
        public override void Deposit(double amount)
        {
            if (amount < 10)
            {
                Console.WriteLine("You must deposit at least $10");
                return;
            }
            base.Deposit(amount);
        }

        // Overrides the Withdraw method to enforce a withdrawal limit of $200 per transaction.
        public override void Withdraw(double amount)
        {
            if (amount > 200)
            {
                Console.WriteLine("You can't withdraw more than $200");
                return;
            }
            // Ensures sufficient balance before withdrawing.
            if (m_balance - amount >= 0)
            {
                base.Withdraw(amount);
            }
        }
    }
}
// SavingsAccount inherits from BankAccount and preserves the core behavior of deposits and withdrawals, while adding specific constraints (minimum deposit and withdrawal limit).
// The modified Deposit method does not remove functionality; it only adds a minimum deposit requirement.
// The modified Withdraw method maintains expected behavior while enforcing a maximum withdrawal limit.
// A SavingsAccount can be used anywhere a BankAccount is expected, ensuring consistent behavior across the system.