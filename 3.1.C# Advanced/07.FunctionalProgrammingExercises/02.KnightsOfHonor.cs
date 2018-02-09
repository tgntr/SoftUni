using System;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class KnightsOfHonor
    {
        static void Main()
        {
            Func<string, string> appendSir= name => $"Sir {name}";
            Action<string> printName = name => Console.WriteLine(name);
            Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(appendSir)
                .ToList()
                .ForEach(printName);
        }
    }
}
