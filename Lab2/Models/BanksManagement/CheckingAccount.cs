namespace Lab2.Models.BanksManagement
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(double balance) : base(balance)
        {
        }

        public override void Deposit(double amount)
        {
            base.Deposit(amount);
        }
        public override void Withdraw(double amount)
        {
            
            if (m_balance - amount - 1 >= 0)
            {
                Console.WriteLine("Withdrawal Successful! A fee of 1$ has been deducted from your account.");
                base.Withdraw(amount + 1);
            }
            else
            {
                Console.WriteLine("You don't have enough money in your account to withdraw this amount.");
            }
        }
    }
}