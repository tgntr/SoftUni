using System;
using System.Linq;

class SieveOfEratosthenes
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool[] primes = SetArrayToTrue(new bool[n + 1]);
        primes[0] = false;
        primes[1] = false;

        for (int i = 2; i <= n; i++)
        {
            if (primes[i] == true)
            {
                Sieve(primes, i);
                Console.Write(i + " ");
            }
        }

    }
    static bool[] SetArrayToTrue (bool[] primes)
    {
        for (int i = 0; i < primes.Length; i++)
        {
            primes[i] = true;
        }
        return primes;
    }
    static bool[] Sieve (bool[] primes, int i)
    {
        int n = 2;
        while (n * i < primes.Length)
        {
            primes[n * i] = false;
            n++;
        }
        return primes;
    }

}