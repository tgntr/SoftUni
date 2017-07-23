using System;

class MasterNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (HasEvenDigit(i))
            {
                if (SumOfDigits(i) % 7 == 0)
                {
                    if (IsSymmetric(i.ToString()))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
    private static bool HasEvenDigit(int n)
    {
        bool evenDigit = false;
        while (n != 0)
        {
            if ((n % 10) % 2 == 0)
            {
                evenDigit = true;
                break;
            }
            n /= 10;
        }
        return evenDigit;
    }
    private static int SumOfDigits(int n)
    {
        int sum = 0;
        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }
    public static bool IsSymmetric(string numberDigits)
    {
        bool symmetric = true;
        for (int i = 0, y = numberDigits.Length-1; i < numberDigits.Length / 2; i++, y--)
        {
            if (numberDigits[i] != numberDigits[y])
            {
                symmetric = false;
                break;
            }
        }
        return symmetric;
    }
}
