using System;
using System.Linq;

namespace _13.TriFunction
{
    class TriFunction
    {
        static void Main()
        {
            var magicNum = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split().ToList();

            Func<string, bool> equalsMagicNum = name => name.Sum(c => c) >= magicNum;
            Console.WriteLine(names.FirstOrDefault(equalsMagicNum));
        }
    }
}
