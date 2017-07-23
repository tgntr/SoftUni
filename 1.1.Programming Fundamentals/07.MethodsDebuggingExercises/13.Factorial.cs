using System;
using System.Numerics;

class Factorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(CalculateFactorial(n));
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
}
