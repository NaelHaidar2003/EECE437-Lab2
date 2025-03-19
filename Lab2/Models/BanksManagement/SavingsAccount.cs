namespace Lab2.Models.BanksManagement
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(double balance) : base(balance)
        {
        }

        public override void Deposit(double amount)
        {
            if(amount < 10)
            {
                Console.WriteLine("You must deposit at least $10");
                return;
            }
            base.Deposit(amount);
        }
        public override void Withdraw(double amount)
        {
            if(amount >200)
            {
                Console.WriteLine("You can't withdraw more than $200");
                return;
            }
            if (m_balance - amount >= 0)
            {
                base.Withdraw(amount);
            }
        }
    }
}