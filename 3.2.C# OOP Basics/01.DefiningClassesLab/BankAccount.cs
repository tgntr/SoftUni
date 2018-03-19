using System;

public class BankAccount
{
    int id;
    decimal balance;

    public int Id
    {
        get { return this.id; }
        set { this.id = value; }
    }

    public decimal Balance
    {
        get { return this.balance; }
        set { this.balance = value; }
    }

    public void Deposit(decimal amount)
    {
        this.Balance += amount;
    }

    public void Withdraw (decimal amount)
    {
        if (this.Balance >= amount)
        {
            this.Balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient balance");
        }
    }

    public BankAccount()
    {

    }

    public BankAccount(int id)
    {
        this.Id = id;
    }

    public override string ToString()
    {
        return $"Account ID{Id}, balance {Balance:F2}";
    }
}
