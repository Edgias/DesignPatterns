namespace Edgias.DesignPatterns.Essentials
{
    public class Account
    {
        private decimal balance;
        public decimal Balance 
        { 
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if(balance > amount)
            {
                balance -= amount;
            }
        }
    }
}