using System;
using System.Collections.Generic;
using System.Linq;

class PizzaIngredients
{
    static void Main()
    {
        string[] ingredients = Console.ReadLine().Split(' ');
        int searchedLength = int.Parse(Console.ReadLine());
        List<string> added = new List<string>();
        for (int i = 0; i < ingredients.Length; i++)
        {
            if (ingredients[i].Length == searchedLength)
            {
                added.Add(ingredients[i]);
                Console.WriteLine($"Adding {ingredients[i]}.");
            }
            if (added.Count == 10)
            {
                break;
            }
        }
        Console.WriteLine($"Made pizza with total of {added.Count} ingredients.");
        Console.Write("The ingredients are: ");
        PrintArray(added);
    }
    static void PrintArray(List<string> added)
    {
        for (int i = 0; i < added.Count; i++)
        {
            if (i == added.Count - 1)
            {
                Console.Write($"{added[i]}.");
            }
            else
            {
                Console.Write($"{added[i]}, ");
            }
        }
    }
}
