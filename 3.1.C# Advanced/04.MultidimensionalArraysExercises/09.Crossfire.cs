using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Crossfire
{
    class Crossfire
    {
        static void Main(string[] args)
        {
            var rowsCols = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            var rows = rowsCols[0];
            var cols = rowsCols[1];

            var field = new List<List<int>>();
            var number = 1;
            for (int row = 0; row < rows; row++)
            {
                field.Add(new List<int>());
                for (int col = 0; col < cols; col++)
                {
                    field[row].Add(number);
                    number++;
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "Nuke it from orbit")
            {
                var shot = input.Split().Select(int.Parse).ToArray();
                var shotRow = shot[0];
                var shotCol = shot[1];
                var shotRadius = shot[2];

                if (shotRow >= 0 && shotRow < field.Count)
                {
                    for (int col = Math.Max(0, shotCol - shotRadius); col <= Math.Min(field[shotRow].Count - 1, shotCol + shotRadius); col++)
                    {
                        field[shotRow][col] = 0;
                    }
                }

                if (shotCol >= 0 && shotCol < cols)
                {
                    for (int row = Math.Max(0, shotRow - shotRadius); row <= Math.Min(field.Count - 1, shotRow + shotRadius); row++)
                    {
                        if (shotCol < field[row].Count)
                        {
                            field[row][shotCol] = 0;
                        }
                    }
                }
               
                foreach (var row in field)
                {
                    row.RemoveAll(x=>x==0);
                }
                field.RemoveAll(x => x.Count == 0);
            }

            foreach (var row in field)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
