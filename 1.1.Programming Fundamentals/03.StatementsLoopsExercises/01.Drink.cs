using System;

class Program
{
    static void Main()
    {
        string job = Console.ReadLine();
        string drink = "";
        if (job == "Athlete")
        {
            drink = "Water";
        }
        else if (job == "Businessman" ||  job == "Businesswoman")
        {
            drink = "Coffee";
        }
        else if (job == "SoftUni Student")
        {
            drink = "Beer";
        }
        else
        {
            drink = "Tea";
        }
        Console.WriteLine(drink);
    }
}

