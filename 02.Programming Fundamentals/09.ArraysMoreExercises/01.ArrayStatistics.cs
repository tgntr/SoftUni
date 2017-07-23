using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        PrdoubleMinNum(input);
        PrdoubleMaxNum(input);
        double sum = SumOfNums(input);
        Console.WriteLine($"Sum = {sum}");
        PrintAverage(input, sum);
    }
    static void PrdoubleMinNum(string input)
    {
        double[] numbers = input.Trim().Split(' ').Select(double.Parse).ToArray();
        double minNum = double.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < minNum)
            {
                minNum = numbers[i];
            }
        }
        Console.WriteLine($"Min = {minNum}");
    }
    static void PrdoubleMaxNum(string input)
    {
        double[] numbers = input.Trim().Split(' ').Select(double.Parse).ToArray();
        double maxNum = double.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > maxNum)
            {
                maxNum = numbers[i];
            }
        }
        Console.WriteLine($"Max = {maxNum}");
    }
    static double SumOfNums(string input)
    {
        double[] numbers = input.Trim().Split(' ').Select(double.Parse).ToArray();
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

}
