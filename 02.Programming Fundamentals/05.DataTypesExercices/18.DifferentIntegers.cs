using System;
using System.Numerics;

class DifferentIntegers
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        long[] maxValues = new long[] { sbyte.MaxValue, byte.MaxValue, short.MaxValue, ushort.MaxValue, int.MaxValue, uint.MaxValue, long.MaxValue };
        long[] minValues = new long[] { sbyte.MinValue, byte.MinValue, short.MinValue, ushort.MinValue, int.MinValue, uint.MinValue, long.MinValue };
        string[] names = new string[] { "sbyte", "byte", "short", "ushort", "int", "uint", "long" };
        
        bool found = false;
        bool[] checkOutput = new bool[] { false, false, false, false, false, false, false, false };
        for (int i = 0; i < maxValues.Length; i++)
        {
            if (n >= minValues[i] && n <= maxValues[i])
            {
                found = true;
                checkOutput[i] = true;
            }
        }
        if (found == false)
        {
            Console.WriteLine($"{n} can't fit in any type");
        }
        else
        {
            Console.WriteLine($"{n} can fit in:");
            for (int y = 0; y < maxValues.Length; y++)
            {
                if (checkOutput[y])
                {
                    Console.WriteLine($"* {names[y]}");
                }
            }
        }
    }
}