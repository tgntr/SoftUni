using System;

class Program
{
    static void Main()
    {
        int count = 0;
        int convert = 0;
        while (count <= 100)
        {
            string input = Console.ReadLine();
            try
            {
                convert = int.Parse(input);
            }
            catch (FormatException)
            {
                break;
            }
            catch (OverflowException)
            {
                break;
            }

            count++;
        }
        Console.WriteLine(count);
    }
}

