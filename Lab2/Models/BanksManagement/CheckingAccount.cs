namespace Lab2.Models.BanksManagement
{
    // The CheckingAccount class inherits from the BankAccount base class.
    // It represents a specific type of bank account with an additional withdrawal fee.
    public class CheckingAccount : BankAccount
    {
        // Constructor: Calls the base class constructor to initialize the balance.
        public CheckingAccount(double balance) : base(balance)
        {
        }

        // Overrides the Deposit method but simply calls the base method (no change in behavior).
        public override void Deposit(double amount)
        {
            base.Deposit(amount);
        }

        // Overrides the Withdraw method to apply a $1 withdrawal fee.
        public override void Withdraw(double amount)
        {
            // Ensures there is enough balance to withdraw the requested amount plus the fee.
            if (m_balance - amount - 1 >= 0)
            {
                Console.WriteLine("Withdrawal Successful! A fee of $1 has been deducted from your account.");
                base.Withdraw(amount + 1); // Calls the base class method with the adjusted amount.
            }
            else
            {
                Console.WriteLine("You don't have enough money in your account to withdraw this amount.");
            }
        }
    }
}
// LSP states that derived classes should be able to replace their base class without altering the correctness of the program.
// The CheckingAccount class extends BankAccount but does not remove or restrict functionality—it only adds a withdrawal fee.
// The overridden Deposit method behaves identically to the base class, ensuring seamless substitution.