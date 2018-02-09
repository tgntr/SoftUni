using System;
using System.Linq;

namespace _01.SortEvenNumbers
{
    class SortEvenNumbers
    {
        static void Main()
        {
            Func<int, bool> numberIsEven = n => n % 2 == 0;
            var numbers = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(numberIsEven)
                .OrderBy(n => n)
                .ToArray();

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
