using System;

class HexadecimalBinary
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        string hex = input.ToString("X");
        string binary = Convert.ToString(input, 2);
        Console.WriteLine("{0} \n{1}", hex, binary);
    }
}
