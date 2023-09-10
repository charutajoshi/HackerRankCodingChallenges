using System;
namespace ConsoleApp1.BankingApp
{
	public class Account
	{
		public Account()
		{
		}

		public string ID { get; set; }
		public double Amount { get; set; }
		public List<DateTime> TimeStamp { get; set; }
    }
}

