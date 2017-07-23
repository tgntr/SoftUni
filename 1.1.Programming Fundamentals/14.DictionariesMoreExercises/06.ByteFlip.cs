using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class ByteFlip
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split().ToList();
        numbers.RemoveAll(x => x.Length != 2);
        for (int i = 0; i < numbers.Count; i++)
        {
            numbers[i] = Reverse(numbers[i]);
        }
        numbers.Reverse();
        foreach (var number in numbers)
        {
            Console.Write((char)Int16.Parse(number, NumberStyles.AllowHexSpecifier));

        }
    }
    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
