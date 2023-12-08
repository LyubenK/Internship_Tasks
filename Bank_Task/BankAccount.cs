using System;
namespace Bank_Task
{
	public class BankAccount : IBanking
	{
        private decimal balance;
        
		public BankAccount(decimal balance)
		{
            this.balance = balance;
		}

        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (balance < 0)
                {
                    throw new ArgumentException("Account balance can not be null");
                }
            }
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public decimal GetBalance()
         => Balance;

        public void Wndraw(decimal amount)
        {
            if (amount > Balance)
            {
                throw new OperationCanceledException("You dont have enough balance in the bank account");
            }

            else
            {
                Balance -= amount;
            }
        }
    }
}

