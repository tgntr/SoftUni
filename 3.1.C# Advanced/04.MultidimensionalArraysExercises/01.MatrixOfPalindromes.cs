using System;
using System.Linq;

namespace _01.MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main()
        {
            var rowsCols = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            var maxMid = rowsCols[1];
            var maxEnds = rowsCols[0];
            var alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            for (int i  = 0 ; i < maxEnds; i++)
            {
                for (int y = i; y < i + maxMid; y++)
                {
                    Console.Write($"{alphabet[i]}{alphabet[y]}{alphabet[i]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
