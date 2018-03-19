using System.Collections.Generic;
using System.Linq;

public class Person
{
    string name;
    int age;
    List<BankAccount> accounts = new List<BankAccount>();

    public Person(string name, int age)
    {
        this.age = age;
        this.name = name;
    }

    public Person(string name, int age, List<BankAccount> accounts)
        :this(name, age)
    {
        this.accounts.AddRange(accounts);
    }

    public decimal GetBalance()
    {
        return this.accounts.Sum(a => a.Balance);
    }
}
