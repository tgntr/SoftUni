using System;
using System.Linq;

namespace _04.AddVAT
{
    class AddVAT
    {
        static void Main()
        {
            Func<string, double> addVAT = n => double.Parse(n) * 1.2;
            var numbers = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(addVAT)
                .ToList();
            Action<double> printNumber = n => Console.WriteLine($"{n:F2}");
            numbers.ForEach(printNumber);
        }
    }
}
