using System;
using System.Collections.Generic;

public class BePositive_broken
{
    public static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());
        string[] output = new string[countSequences];
        for (int i = 0; i < countSequences; i++)
        {
            string[] input = Console.ReadLine().Trim().Split(' ');
            var numbers = new List<int>();

            for (int y = 0; y < input.Length; y++)
            {
                if (input[y] != "")
                {
                    int num = int.Parse(input[y]);
                    numbers.Add(num);
                }

            }
            bool found = false;
            int currentNum = 0;
            string save = "";
            for (int j = 0; j < numbers.Count; j++)
            {
                currentNum = numbers[j];
                if (currentNum < 0)
                {
                    if (j + 1 < numbers.Count)
                    {
                        j++;
                    }
                    currentNum += numbers[j];

                    if (currentNum >= 0)
                    {
                        found = true;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    found = true;
                }
                if (found)
                {
                    save += currentNum + " "; 
                }

            }
            if (!found)
            {
           
                output[i] = "(empty)";
           
            }
            else
            {
                output[i] = save.Trim();
            }
        }
        for (int i = 0; i < countSequences; i++)
        {
            Console.WriteLine(output[i]);
        }
    }
}