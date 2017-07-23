using System;
using System.Linq;


class FoldAndSum
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        FoldSum(input);
    }
    static void FoldSum (string[] input)
    {
        string left = "";
        string middle = "";
        string right = "";
        for (int i = 0; i < input.Length; i++)
        {
            int quarterOfLength = (input.Length / 2) / 2;
            if (i < quarterOfLength)
            {
                left += input[i] + ' ';
            }
            else if (i < input.Length - quarterOfLength)
            {
                middle += input[i] + ' ';
            }
            else
            {
                right += input[i] + ' ';
            }
        }
        string folded = Reverse(left) + Reverse(right).Trim();
        int[] foldedNumbers = folded.Split(' ').Select(int.Parse).ToArray();
        int[] middleNumbers = middle.Trim().Split(' ').Select(int.Parse).ToArray();
        int[] sum = new int[middleNumbers.Length];
        for (int i = 0; i < sum.Length; i++)
        {
            sum[i] = foldedNumbers[i] + middleNumbers[i];
        }
        PrintArray(sum);
    }
    static string Reverse (string input)
    {
        string[] toReverse = input.Trim().Split(' ');
        string reversed = "";
        if (input.Trim().Length == 1)
        {
            return input;
        }
        for (int i = toReverse.Length - 1; i >= 0; i--)
        {
            reversed += toReverse[i] + " ";
        }
        return reversed;
    }
    static void PrintArray(int[] sum)
    {
        for (int i = 0; i < sum.Length; i++)
        {
            Console.Write($"{sum[i]} ");
        }
    }
}
