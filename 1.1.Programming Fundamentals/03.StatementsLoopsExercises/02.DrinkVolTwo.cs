using System;

class Program
{
    static void Main()
    {
        string job = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());
        double price = 0;
        string drink = "";

        if (job == "Athlete")
        {
            drink = "Water";
            price = quantity * 0.7;
        }
        else if (job == "Businessman" || job == "Businesswoman")
        {
            drink = "Coffee";
            price = quantity * 1;
        }
        else if (job == "SoftUni Student")
        {
            drink = "Beer";
            price = quantity * 1.7;
        }
        else
        {
            drink = "Tea";
            price = quantity * 1.2;
        }
        Console.WriteLine("The {0} has to pay {1:F2}", job, price);
    }
}