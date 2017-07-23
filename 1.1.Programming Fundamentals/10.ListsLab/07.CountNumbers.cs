using System;
using System.Collections.Generic;
using System.Linq;

class CountNumbers
{
    static void Main()
    {
        var numbers = Console.ReadLine().Trim().Split(' ').Select(double.Parse).ToList<double>();
        numbers.Sort();
        while (numbers.Count > 0)
        {
            double currentNumber = numbers[0];
            var equal = new List<double>();
            equal.AddRange(numbers.Where(x=>x==currentNumber));
            Console.WriteLine($"{currentNumber} -> {equal.Count}");
            numbers.RemoveAll(x => x == currentNumber);

        }
    }
}
