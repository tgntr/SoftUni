using System;
using System.Collections.Generic;
using System.Linq;

class ChangeList
{
    static void Main()
    {
        var numbers = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList<int>();
        var command = new List<string>();
        command.Add("");

        while(command[0] != "Odd" && command[0] != "Even")
        {
            command = Console.ReadLine().Trim().Split(' ').ToList<string>();
            if (command.Count > 2)
            {
                var element = int.Parse(command[1]);
                var position = int.Parse(command[2]);
                numbers.Insert(position, element);
            }
            else if(command.Count > 1)
            {
                var element = int.Parse(command[1]);
                numbers.RemoveAll(x => x == element);
            }
            else if (command[0] == "Odd")
            {
                numbers.RemoveAll(x => x % 2 == 0);
            }
            else
            {
                numbers.RemoveAll(x => x % 2 == 1);
            }
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}
