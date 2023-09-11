using System;
namespace ConsoleApp1.BankingApp
{
	public class BankingApp
	{
		private List<Account> accounts = new List<Account>();

		public BankingApp()
		{
		}

		public void CreateAccount(string acctID, DateTime time)
		{
			List<string> ids = new List<string>();

			foreach (var acct in accounts)
			{
				ids.Add(acct.ID); 
			}

			if (!ids.Contains(acctID))
			{
				Account newAcct = new Account();
				newAcct.ID = acctID;
				List<DateTime> dateTimes = new List<DateTime>();
				dateTimes.Add(time);
				newAcct.TimeStamp = dateTimes; 
				Console.WriteLine($"Account {acctID} created.");
            }
            else
			{
				Console.WriteLine($"Account {acctID} already exists."); 
			}
		}

		public void Deposit(string acctID, DateTime time, double amount)
		{
			foreach (var acct in accounts)
			{
				if (acct.ID == acctID)
				{
					acct.Amount += amount; 
				}
			}
		}

		public void Payment(string acctID, DateTime time, double amount)
		{
            foreach (var acct in accounts)
            {
                if (acct.ID == acctID)
                {
                    acct.Amount = acct.Amount - amount;
                }
            }
        }
	}
}

