using System;
using System.Linq;
class RotateAndSum
{
    static void Main()
    {
        string input = Console.ReadLine();
        int rotate = int.Parse(Console.ReadLine());
        int[] inputNumbers = input.Split(' ').Select(int.Parse).ToArray();
        int[] sum = new int[inputNumbers.Length];
        for (int i = 0; i < rotate; i++)
        {
            inputNumbers = ArrayShiftRight(inputNumbers);
            for (int y = 0; y < inputNumbers.Length; y++)
            {
                sum[y] += inputNumbers[y];
            }
        }
        for (int i = 0; i < inputNumbers.Length; i++)
        {
            Console.Write($"{sum[i]} ");
        }
    }
    private static int[] ArrayShiftRight(int[] numbers)
    {
        int save = numbers[numbers.Length - 1];
        for (int i = numbers.Length - 1; i > 0; i--)
        {
            numbers[i] = numbers[i - 1];
        }
        numbers[0] = save;
        return numbers;
    }
}
