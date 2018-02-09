using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> wordIsUppercase = w => Char.IsUpper(w[0]);
            var words = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Where(wordIsUppercase)
                .ToArray();
            Console.WriteLine(string.Join("\n", words));
        }
    }
}
