using System;
using System.Collections.Generic;

class Startup
{
    static void Main()
    {
        var input = "";

        var dough = new Dough();

        var toppings = new List<Topping>();

        var pizza = new Pizza();

        while ((input = Console.ReadLine()) != "END")
        {
            if (input.Contains("Dough"))
            {
                try
                {
                    dough = new Dough(input);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    return;
                }
            }
            else if (input.Contains("Topping"))
            {
                try
                {
                    toppings.Add(new Topping(input));
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    return;
                }
            }
            else
            {
                try
                {
                    pizza.Name = input.Split()[1].Trim();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    return;
                }
            }
        }

        try
        {
            pizza.Dough = dough;
            pizza.Toppings = toppings;
            Console.WriteLine(pizza);
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}
