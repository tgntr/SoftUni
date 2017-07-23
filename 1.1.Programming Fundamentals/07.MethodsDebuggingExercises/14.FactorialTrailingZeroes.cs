using System;
using System.Numerics;

class Factorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger factorialOfN = (CalculateFactorial(n));
        Console.WriteLine(TrailingZeroes(factorialOfN));
    }
    static BigInteger CalculateFactorial(int n)
    {
        BigInteger factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
    static int TrailingZeroes(BigInteger n)
    {
        bool isZero = true;
        int zeroesCount = 0;
        while (n != 0)
        {
            if (n % 10 != 0)
            {
                isZero = false;
                break;
            }
            zeroesCount++;
            n /= 10;
        }
        return zeroesCount;
    }
}