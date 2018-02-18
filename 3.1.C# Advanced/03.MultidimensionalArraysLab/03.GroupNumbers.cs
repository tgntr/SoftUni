using System;
using System.Linq;

namespace _03.GroupNumbers
{
    class GroupNumbers
    {
        static void Main()
        {
            var groupsLength = new int[3];


            var inputNumbers = Console.ReadLine()
                    .Split(new string[] { ", " }, StringSplitOptions.None)
                    .Select(int.Parse)
                    .ToArray();
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                var currentGroup = Math.Abs(inputNumbers[i] % 3);
                groupsLength[currentGroup]++;
            }

            var numbersByGroup = new int[3][];

            for (int y = 0; y < 3; y++)
            {
                numbersByGroup[y] = new int[groupsLength[y]];
            }

            var currentIndexes = new int[3];

            for (int z = 0; z < inputNumbers.Length; z++)
            {
                var currentGroup = Math.Abs(inputNumbers[z] % 3);
                numbersByGroup[currentGroup][currentIndexes[currentGroup]] = inputNumbers[z];
                currentIndexes[currentGroup]++;
            }

            for (int x = 0; x < numbersByGroup.Length; x++)
            {
                for (int c = 0; c < numbersByGroup[x].Length; c++)
                {
                    Console.Write($"{numbersByGroup[x][c]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
