using System;

class FootballLeague
{
    static void Main()
    {
        int capacity = int.Parse(Console.ReadLine());
        int fans = int.Parse(Console.ReadLine());
        double a = 0;
        double b = 0;
        double v = 0;
        double g = 0;
        for (int i = 0; i < fans; i++)
        {
            string currentFan = Console.ReadLine();
            if (currentFan == "A")
            {
                a++;
            }
            if (currentFan == "B")
            {
                b++;
            }
            if (currentFan == "V")
            {
                v++;
            }
            else if (currentFan == "G")
            {
                g++;
            }
        }
        a = a / fans * 100;
        b = b / fans * 100;
        v = v / fans * 100;
        g = g / fans * 100;
        double total = (double)fans / capacity * 100;
        Console.WriteLine("{0:F2}% \n{1:F2}% \n{2:F2}% \n{3:F2}% \n{4:F2}%", a, b, v, g, total);
    }
}