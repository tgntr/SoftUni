using System;

namespace _04.PascalTriangle
{
    class PascalTriangle
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var triangle = new long[n][];
            triangle[0] = new long[1] { 1 };
            Console.WriteLine(1);
            for (long i = 1; i < n; i++)
            {
                triangle[i] = new long[i + 1];
                triangle[i][0] = 1;
                triangle[i][i] = 1;

                for (long y = 1; y < i; y++)
                {
                    var leftNumber = triangle[i - 1][y - 1];
                    var rightNumber = triangle[i - 1][y];
                    triangle[i][y] = leftNumber + rightNumber;
                }

                Console.WriteLine(string.Join(" ", triangle[i]));
            }
        }
    }
}
