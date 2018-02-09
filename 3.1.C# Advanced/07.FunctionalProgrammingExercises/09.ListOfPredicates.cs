using System;
using System.Linq;

namespace _09.ListOfPredicates
{
    class ListOfPredicates
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var divisors = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(div => (Func<int, bool>)(num => num % int.Parse(div) == 0))
                .ToArray();
            try
            {
                Func<int, bool> numberIsDividable = num => isDividable(num, divisors);
                var numbers = Enumerable.Range(1, n)
                    .Where(numberIsDividable)
                    .ToList();
                Console.WriteLine(string.Join(" ", numbers));
            }
            catch (Exception)
            {
                return;
            }
        }

        static bool isDividable(int n, Func<int, bool>[] divisors)
        {
            foreach (var divisor in divisors)
            {
                if (!divisor(n))
                    return false;
            }
            return true;
        }
    }
}
