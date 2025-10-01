namespace DesignPatterm
{
	internal class BankAccount
	{
		private decimal balance;

		public BankAccount(decimal balance)
		{
			Deposit(balance);
		}

		public void Deposit(decimal amount)
		{
			if (amount <= 0)
				throw new ArgumentOutOfRangeException(nameof(amount), "Deposit amount must be positive.");

			balance += amount;
		}

		public void Withdraw(decimal amount)
		{
			if (amount <= 0)
				throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal amount must be positive.");
			if (amount > balance)
				throw new InvalidOperationException("Insufficient funds for this withdrawal.");

			balance -= amount;
		}

		public decimal GetBalance() => balance;
	}
}
