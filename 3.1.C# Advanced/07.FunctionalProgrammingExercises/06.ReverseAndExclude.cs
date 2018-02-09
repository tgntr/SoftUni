using System;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class ReverseAndExclude
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var divisor = int.Parse(Console.ReadLine());
            Predicate<int> areDivisable = n => n % divisor == 0;
            numbers.Reverse();
            numbers.RemoveAll(areDivisable);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
