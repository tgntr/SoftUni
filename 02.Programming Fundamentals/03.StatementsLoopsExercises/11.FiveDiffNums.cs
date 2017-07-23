using System;

class FiveDiffNums
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int limit = b - a;
        if (limit < 4)
        {
            Console.WriteLine("No");
        }
        else
        {
            for (int i = a; i <= b - 4; i++)
            {
                for (int y = i + 1; y <= b - 3; y++)
                {
                    for (int z = y + 1; z <= b - 2; z++)
                    {
                        for (int x = z + 1; x <= b - 1; x++)
                        {
                            for (int l = x + 1; l <= b; l++)
                            {
                                Console.WriteLine("{0} {1} {2} {3} {4}", i, y, z, x, l);
                            }
                        }
                    }
                }
            }
        }
    }
}

