using System;

class Prime
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        Console.WriteLine(PrimeCheck(input));
    }
    static bool PrimeCheck(long input)
    {
        bool prime = false;
        if (input == 2 || input == 3)
        {
            prime = true;
        }
        for (long i = 2; i <= Math.Sqrt(input); i++)
        {
            prime = true;
            if (input % i == 0)
            {
                prime = false;
                break;
            }
            
        }
        return prime;
    }
}