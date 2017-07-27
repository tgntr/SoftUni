using System;
using System.Collections.Generic;
using System.Linq;

class PokemonDontGo
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split().Where(x => x != "").Select(decimal.Parse).ToList();
        var sumOfRemovedNumbers = 0m;
        while (numbers.Count > 0)
        {
            var index = int.Parse(Console.ReadLine());
            var currentNumber = 0m;
            if (index < 0)
            {
                currentNumber = numbers[0];
                sumOfRemovedNumbers += currentNumber;
                numbers[0] = numbers[numbers.Count - 1];
            }
            else if(index >= numbers.Count)
            {
                currentNumber = numbers.Last();
                sumOfRemovedNumbers += currentNumber;
                numbers[numbers.Count - 1] = numbers[0];
            }
            else
            {
                currentNumber = numbers[index];
                sumOfRemovedNumbers += currentNumber;
                numbers.RemoveAt(index);
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= currentNumber)
                {
                    numbers[i] += currentNumber;
                }
                else
                {
                    numbers[i] -= currentNumber;
                }
            }
        }
        Console.WriteLine(sumOfRemovedNumbers);
    }
}