using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class CustomMinFunction
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Func<int[], int> findSmallestNumber= n => n.Min();
            var smallestNumber = findSmallestNumber(numbers);
            Console.WriteLine(smallestNumber);
        }
    }
}
