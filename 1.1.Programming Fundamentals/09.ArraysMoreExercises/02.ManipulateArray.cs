using System;
using System.Collections.Generic;
using System.Linq;

class ManipulateArray
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int commands = int.Parse(Console.ReadLine());
        for (int i = 0; i < commands; i++)
        {
            string command = Console.ReadLine();
            if(command == "Reverse")
            {
                input = input.Reverse().ToArray();
            }
            else if(command== "Distinct")
            {
                input = input.Distinct().ToArray();
            }
            else
            {
                int index = int.Parse(command.Split(' ')[1]);
                string replaceWith = command.Split(' ')[2];
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
// static void Main()
// {
//     List<string> input = (Console.ReadLine().Split(' ')).ToList();
//
//     int numberOfCommands = int.Parse(Console.ReadLine());
//     for (int i = 0; i < numberOfCommands; i++)
//     {
//         string command = Console.ReadLine();
//         if (command == "Reverse")
//         {
//             input = ReverseArray(input);
//         }
//         else if (command == "Distinct")
//         {
//             input = DistinctNonUniqueElements(input);
//         }
//         else if (command.Split(' ')[0] == "Replace")
//         {
//             input = ReplaceAtPosition(input, int.Parse(command.Split(' ')[1]), command.Split(' ')[2]);
//         }
//     }
//     PrintArray(input);
//
//
// }
// static List<string> ReverseArray(List<string> input)
// {
//     List<string> reversed = new List<string>();
//     for (int y = input.Count-1 ; y <= 0; y--)
//     {
//         reversed.Add(input[y]);
//     }
//     return reversed;
// }
// static List<string> DistinctNonUniqueElements(List<string>input)
// {
//     for (int i = 0; i < input.Count; i++)
//     {
//         string current = input[i];
//         if (input[i] == "")
//         {
//             continue;
//         }
//         for (int y = 0; y < input.Count; y++)
//         {
//             if (current == input[y] && y != i)
//             {
//                 input[i] = "";
//                 input[y] = "";
//             }
//         }
//     }
//     List<string> distincted = new List<string>();
//     for (int i = 0; i < input.Count; i++)
//     {
//         if (input[i] != "")
//         {
//             distincted.Add(input[i]);
//         }
//     }
//     return distincted;
// }
// static List<string> ReplaceAtPosition (List<string> input, int index, string replaceWith)
// {
//     input[index - 1] = replaceWith;
//     return input;
// }
// static void PrintArray(List<string> input)
// {
//     for (int i = 0; i < input.Count; i++)
//     {
//         if (i == input.Count - 1)
//         {
//             Console.WriteLine(input[i]);
//         }
//         else
//         {
//             Console.WriteLine(input[i] + " ");
//         }
//     }
// }


