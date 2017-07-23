using System;
using System.Collections.Generic;
using System.Linq;

class BombNumbers
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList<long>();

        var parameters = Console.ReadLine().Split(' ').Select(long.Parse).ToList<long>();
        int bombIndex = numbers.FindIndex(x => x == parameters[0]);
        while (bombIndex >= 0)
        {
            if (parameters[1] < 1)
            {
                numbers.RemoveAt(bombIndex);
            }
            else
            {
                numbers = RemoveRange(numbers, bombIndex, parameters[1]).ToList();
            }
            bombIndex = -1;
            bombIndex = numbers.FindIndex(x => x == parameters[0]);
        }
        Console.WriteLine(numbers.Sum());

    }
    static List<long> RemoveRange(List<long> numbers, int bombIndex, long range)
    {
        int index = bombIndex + 1;
        for (int i = 0; i < range; i++)
        {
            if (index > numbers.Count-1)
            {
                break;
            }
            numbers.RemoveAt(index);
        }
        numbers.RemoveAt(bombIndex);
        index = bombIndex - 1;
        for (int i = 0; i < range; i++)
        {
            if (index < 0)
            {
                break;
            }
            numbers.RemoveAt(index);
            index--;
        }
        return numbers;
    }
}
