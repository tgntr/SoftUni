using System;
using System.Collections.Generic;
using System.Linq;

class Ladybugs
{
    static void Main()
    {
        var size = long.Parse(Console.ReadLine());
        var ladyBugs = Console.ReadLine().Split().Select(long.Parse).Distinct().Where(x=>x>=0 && x<size).ToList();
        while (true)
        {
            var input = Console.ReadLine().Split();
            if (input[0] == "end")
            {
                break;
            }
            var fromIndex = long.Parse(input[0]);
            if (ladyBugs.Contains(fromIndex))
            {
                ladyBugs.Remove(fromIndex);
                var length = long.Parse(input[2]);
                if (input[1] == "right")
                {
                    var toIndex = fromIndex + length;
                    while (ladyBugs.Contains(toIndex))
                    {
                        toIndex += length;
                    }
                    if (toIndex >= 0 && toIndex < size)
                    {
                        ladyBugs.Add(toIndex);
                    }
                }
                else
                {
                    var toIndex = fromIndex - length;
                    while (ladyBugs.Contains(toIndex))
                    {
                        toIndex -= length;
                    }
                    if (toIndex >= 0 && toIndex < size)
                    {
                        ladyBugs.Add(toIndex);
                    }
                }
            }
        }
        for (long i = 0; i < size; i++)
        {
            if (ladyBugs.Contains(i))
            {
                Console.Write("1 ");
            }
            else
            {
                Console.Write("0 ");
            }
        }
    }
}


