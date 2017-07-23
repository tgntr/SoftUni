using System;
using System.Collections.Generic;
using System.Linq;

class ManipulateArray
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        string[] command = new string[3];
        while (command[0] != "END")
        {
            command = Console.ReadLine().Split(' ');

            if (command[0] == "Reverse")
            {
                input = input.Reverse().ToArray();
            }
            else if (command[0] == "Distinct")
            {
                input = input.Distinct().ToArray();
            }
            else if (command[0] == "END")
            {
                break;
            }

            else if(command[0] == "Replace" && (int.Parse(command[1]) < 0 || int.Parse(command[1]) >= input.Length))
            {
                Console.WriteLine("Invalid input!");
            }
            else if (command[0] != "Replace")
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                int index = int.Parse(command[1]);
                string replaceWith = command[2];
                input[index] = replaceWith;
            }
        }
        for (int i = 0; i < input.Length; i++)
        {
            if (i == input.Length - 1)
            {
                Console.Write($"{input[i]}");
            }
            else
            {
                Console.Write($"{input[i]}, ");
            }
        }
    }
}
