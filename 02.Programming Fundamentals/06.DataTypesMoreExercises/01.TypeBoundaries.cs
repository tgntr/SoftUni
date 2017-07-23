using System;

class TypeBoundaries
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (input == "int")
        {
            Console.WriteLine($"{int.MaxValue} \n{int.MinValue}");
        }
        else if (input == "uint")
        {
            Console.WriteLine($"{uint.MaxValue} \n{uint.MinValue}");
        }
        else if (input == "long")
        {
            Console.WriteLine($"{long.MaxValue} \n{long.MinValue}");
        }
        else if (input == "byte")
        {
            Console.WriteLine($"{byte.MaxValue} \n{byte.MinValue}");
        }
        else if (input == "sbyte")
        {
            Console.WriteLine($"{sbyte.MaxValue} \n{sbyte.MinValue}");
        }
    }
}