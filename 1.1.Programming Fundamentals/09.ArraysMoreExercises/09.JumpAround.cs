using System;
using System.Collections.Generic;
using System.Linq;

class JumpAround
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int index = 0;
        int sum = numbers[index];
        while (index >= 0 && index < numbers.Length)
        {
            if (index + numbers[index] < numbers.Length)
            {
                index += numbers[index];
                sum += numbers[index];
            }
            else if (index - numbers[index] >= 0)
            {
                index -= numbers[index];
                sum += numbers[index];
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(sum);
    }
}
