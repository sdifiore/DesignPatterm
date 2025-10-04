namespace DesignPatterm
{
	internal class EmailService
	{
		public void SendEmail()
		{
			Connect();
			Authenticate();
			Console.WriteLine($"Sending Email ...");
			Disconnect();
		}

		private void Connect()
		{
			Console.WriteLine("Connecting to email server...");
		}

		private void Authenticate()
		{
			Console.WriteLine("Authenticating to email server...");
		}

		private void Disconnect()
		{
			Console.WriteLine("Disconnecting to email server...");
		}
	}
}
