using System;

class DNA
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        char[] elements = new char[5];
        elements[1] = 'A';
        elements[2] = 'C';
        elements[3] = 'G';
        elements[4] = 'T';
        char element;
        int count = 0;
        for (int i = 1; i <= 4; i++)
        {
            for (int y = 1; y <= 4; y++)
            {
                for (int z = 1; z <= 4; z++)
                {
                    
                    if (i + y + z >= input)
                    {
                        element = 'O';
                    }
                    else
                    {
                        element = 'X';
                    }
                    Console.Write("{0}{1}{2}{3}{4} ", element, elements[i], elements[y], elements[z], element);
                    count++;
                    if (count % 4 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
