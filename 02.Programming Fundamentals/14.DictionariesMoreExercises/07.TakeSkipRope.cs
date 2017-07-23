using System;
using System.Collections.Generic;
using System.Linq;

class TakeSkipRope
{
    static void Main()
    {
        var letters = Console.ReadLine().ToCharArray();
        var input = letters.Select(x=>x.ToString()).ToList<string>();
        var takeNumbers = new List<int>();
        var skipNumbers = new List<int>();
        int numberCount = -1;
        for (int i = 0; i < input.Count; i++)
        {
            if (Char.IsDigit(Convert.ToChar(input[i])))
            {
                numberCount++;

                if (numberCount % 2 == 0)
                {
                    takeNumbers.Add(int.Parse(input[i].ToString()));
                }
                else
                {
                    skipNumbers.Add(int.Parse(input[i].ToString()));
                }
            }
        }
        input.RemoveAll(x => Char.IsDigit(Convert.ToChar(x)));
        int total = 0;
        var word = new List<string>();
        for (int i = 0; i < takeNumbers.Count; i++)
        {
            var currentTake = input.Skip(total).Take(takeNumbers[i]).ToList();
            word.AddRange(currentTake);
            
            total += takeNumbers[i] + skipNumbers[i];
        }
        Console.WriteLine(string.Join("", word));
    }
}