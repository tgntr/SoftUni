using System;

class Reverse
{
    static void Main()
    {
        double input = double.Parse(Console.ReadLine());
        Console.WriteLine(Reverser(input));
    }
    static double Reverser(double input)
    {
        char[] elements = input.ToString().ToCharArray();
        string reversed = "";
        for (int i = elements.Length - 1; i >= 0; i--)
        {
            reversed += elements[i];
        }
        return double.Parse(reversed);
    }
}
