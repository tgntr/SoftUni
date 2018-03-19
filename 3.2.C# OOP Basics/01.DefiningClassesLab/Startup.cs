using System;
using System.Collections.Generic;
using System.Linq;

class Startup
{
    static void Main(string[] args)
    {
       var accounts = new List<BankAccount>();
       var input = "";
       while ((input = Console.ReadLine()) != "End")
       {
           var operationInfo = input.Split();
           var operation = operationInfo[0];
           var accountId = int.Parse(operationInfo[1]);
           var accountIndex = accounts.FindIndex(a => a.Id == accountId);
       
           if (operation == "Create")
           {
               if (accounts.Any(a=>a.Id == accountId))
               {
                   Console.WriteLine("Account already exists");
               }
               else
               {
                   accounts.Add(new BankAccount(accountId));
               }
           }
           else if (accountIndex < 0)
           {
               Console.WriteLine("Account does not exist");
               continue;
           }
           else if (operation == "Deposit")
           {
               var amount = decimal.Parse(operationInfo[2]);
               accounts[accountIndex].Deposit(amount);
           }
           else if (operation == "Withdraw")
           {
               var amount = decimal.Parse(operationInfo[2]);
               accounts[accountIndex].Withdraw(amount);
           }
           else
           {
               Console.WriteLine(accounts[accountIndex]);
           }
       }
    }
}
