using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SimpleTextEditor
{
    class SimpleTextEditor
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var edits = new Stack<int[]>();
            var result = new Stack<char>();
            var undoData = new Stack<char>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var command = int.Parse(input[0]);
                
                if (command == 1)
                {
                    var argument = input[1];
                    foreach (var character in argument)
                    {
                        result.Push(character);
                    }
                    var editInfo = new int[] { 1, argument.Length };
                    edits.Push(editInfo);
                }
                else if (command == 2)
                {
                    
                    var argument = int.Parse(input[1]);
                    for (int y  = 0; y < argument; y++)
                    {
                        undoData.Push(result.Pop());
                    }
                    var editInfo = new int[] { 2, argument };
                    edits.Push(editInfo);
                }
                else if (command == 3)
                {
                    var argument = int.Parse(input[1]);
                    var edit = new Stack<char>();
                    for (int z = result.Count; z > argument; z--)
                    {
                        edit.Push(result.Pop());
                    }
                    Console.WriteLine(result.Peek());
                    while (edit.Count > 0)
                    {
                        result.Push(edit.Pop());
                    }
                }
                else
                {
                    var lastEdit = edits.Peek()[0];
                    if (lastEdit == 1)
                    {
                        var removeLength = edits.Peek()[1];
                        for (int x = 0; x < removeLength; x++)
                        {
                            result.Pop();
                        }
                    }
                    else
                    {
                        var undoLength = edits.Peek()[1];
                        for (int c = 0; c < undoLength; c++)
                        {
                            result.Push(undoData.Pop());
                        }
                    }
                    edits.Pop();
                }
            }
        }

    }
}
