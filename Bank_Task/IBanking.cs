using System;
namespace Bank_Task
{
	public interface IBanking
	{
		public void Wndraw(decimal amount);

		public void Deposit(decimal amount);

		public decimal GetBalance();
	}
}

