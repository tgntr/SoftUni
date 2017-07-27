using System;

class PoolPipes
{
    static void Main()
    {
        int poolSize = int.Parse(Console.ReadLine());
        int firstPipe = int.Parse(Console.ReadLine());
        int secondPipe = int.Parse(Console.ReadLine());
        double hoursMissing = double.Parse(Console.ReadLine());
        double sum = (firstPipe * hoursMissing) + (secondPipe * hoursMissing);
        if (sum <= poolSize)
        {
            int percentFull = (int) ((sum / poolSize) * 100);
            int percentFirst = (int) ((firstPipe * hoursMissing / sum) * 100);
            int percentSecond = (int) ((secondPipe * hoursMissing / sum) * 100);
            Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", percentFull, percentFirst,
                percentSecond);
        }
        else
        {
            Console.WriteLine("For {0} hours the pool overflows with {1:F1} liters.", hoursMissing, sum - poolSize);
        }
    }
}