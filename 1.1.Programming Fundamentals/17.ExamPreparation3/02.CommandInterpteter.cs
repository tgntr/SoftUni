using System;
using System.Collections.Generic;
using System.Linq;

class CommandInterpteter
{
    static void Main()
    {
        var strings = Console.ReadLine().Split().Select(x => x.Trim()).ToList();
        var input = Console.ReadLine().Split();
        while (input[0] != "end")
        {
            if (input[0] == "reverse")
            {
                var startIndex = int.Parse(input[2]);
                var count = int.Parse(input[4]);
                if (startIndex < 0 || startIndex >= strings.Count || count < 0 || startIndex + count > strings.Count)
                {
                    Console.WriteLine("Invalid input parameters.");
                }
                else
                {
                    strings.Reverse(startIndex, count);
                }
            }
            else if (input[0] == "sort")
            {
                var startIndex = int.Parse(input[2]);
                var count = int.Parse(input[4]);
                if (startIndex < 0 || startIndex >= strings.Count || count < 0 || startIndex + count > strings.Count)
                {
                    Console.WriteLine("Invalid input parameters.");
                }
                else
                {
                    strings.Sort(startIndex, count, null);
                }
            }
            else if (input[0] == "rollLeft")
            {
                var count = int.Parse(input[1]);
                if (count < 0)
                {
                    Console.WriteLine("Invalid input parameters.");
                }
                else
                {
                    strings = RollLeft(strings, count);
                }
            }
            else
            {
                var count = int.Parse(input[1]);
                if (count < 0)
                {
                    Console.WriteLine("Invalid input parameters.");
                }
                else
                {
                    strings = RollRight(strings, count);
                }
            }
            input = Console.ReadLine().Split();
        }
        Console.WriteLine($"[{string.Join(", ", strings)}]");
    }
    static List<string> RollLeft(List<string> input, int count)
    {
        for (int i = 0; i < count % input.Count; i++)
        {
            var save = input[0];
            input.RemoveAt(0);
            input.Add(save);
        }
        return input;
    }
    static List<string> RollRight(List<string> input, int count)
    {
        for (int i = 0; i < count % input.Count; i++)
        {
            var save = input[input.Count - 1];
            input.RemoveAt(input.Count - 1);
            input.Insert(0, save);
        }
        return input;
    }
}