using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.StringMatrixRotation
{
    class StringMatrixRotation
    {
        static void Main()
        {
            var degrees = int.Parse(Console.ReadLine().Split(new string[] { "(", ")" }, StringSplitOptions.RemoveEmptyEntries)[1]) % 360;

            string input;
            var words = new List<string>();
            while ((input = Console.ReadLine()) != "END")
            {
                words.Add(input);
            }

            var rows = words.Count;
            var cols = words.OrderByDescending(x => x.Length).First().Length;

            if (degrees == 90)
            {
                var rotatedWords = new char[cols, rows];
                var col = rows - 1;
                
                foreach (var word in words)
                {
                    var row = 0;
                    foreach (var character in word)
                    {
                        rotatedWords[row, col] = character;
                        row++;
                    }
                    while (row < cols)
                    {
                        rotatedWords[row, col] = ' ';
                        row++;
                    }
                    col--;
                }
                PrintWords(rotatedWords);
            }
            else if (degrees == 180)
            {
                var rotatedWords = new char[rows,cols];
                
                var row = rows - 1;
                foreach (var word in words)
                {
                    var col = cols - 1;
                    foreach (var character in word)
                    {
                        rotatedWords[row, col] = character;
                        col--;
                    }
                    while (col >= 0)
                    {
                        rotatedWords[row, col] = ' ';
                        col--;
                    }
                    row--;
                }
                PrintWords(rotatedWords);
            }
            else if (degrees == 270)
            {
                var rotatedWords = new char[cols, rows];
                var col = 0;
                
                foreach (var word in words)
                {
                    var row = cols - 1;
                    foreach (var character in word)
                    {
                        rotatedWords[row, col] = character;
                        row--;
                    }
                    while (row >= 0)
                    {
                        rotatedWords[row, col] = ' ';
                        row--;
                    }
                    col++;
                }
                PrintWords(rotatedWords);
            }
            else
            {
                Console.WriteLine(string.Join("\n", words));
            }
        }

        static void PrintWords (char[,] words)
        {
            for (int row = 0; row < words.GetLength(0); row++)
            {
                for (int col = 0; col < words.GetLength(1); col++)
                {
                    Console.Write(words[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
