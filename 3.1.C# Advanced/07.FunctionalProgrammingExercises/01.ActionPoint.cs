using System;
using System.Linq;

namespace _01.ActionPoint
{
    class ActionPoint
    {
        static void Main()
        {
            Action<string> print = s => Console.WriteLine(s);
            Console.ReadLine()
                .Split()
                .ToList()
                .ForEach(print);
        }
    }
}
