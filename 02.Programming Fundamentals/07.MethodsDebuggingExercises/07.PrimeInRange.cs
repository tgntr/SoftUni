using System;

class PrimeInRange
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        PrimesInRange(a, b);
    }
    static void PrimesInRange(int a, int b)
    {
        string save = "";
        for (int i = a; i <= b; i++)
        {
            bool prime = true;
            for (int y = 2; y <= Math.Sqrt(i); y++)
            {
                prime = true;
                if (i % y == 0 || i == 0 || i == 1)
                {
                    prime = false;
                    break;
                }
            }
            if (prime && i > 1)
            {
                save += i + ", ";
            }
        }
        save = save.Remove(save.Length - 2, 2);
        Console.WriteLine(save);
    }
}
