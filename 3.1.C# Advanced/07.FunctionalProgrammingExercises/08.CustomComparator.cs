using System;
using System.Linq;

namespace _08.CustomComparator
{
    class CustomComparator
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, int, int> comparator = (n1, n2) =>
                  {
                      if (n1 % 2 == 0 && n2 % 2 != 0)
                          return -1;
                      else if (n1 % 2 != 0 && n2 % 2 == 0)
                          return 1;
                      else
                          return n1.CompareTo(n2);
                  };
            Array.Sort(numbers, new Comparison<int>(comparator));
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
