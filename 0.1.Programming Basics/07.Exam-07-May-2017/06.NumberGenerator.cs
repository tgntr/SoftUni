using System;

class NumberGenerator
{
    static void Main()
    {
        string m = Console.ReadLine();

        string n = Console.ReadLine();
        string l = Console.ReadLine();
        int num = int.Parse(m + n + l);
        int special = int.Parse(Console.ReadLine());
        int control = int.Parse(Console.ReadLine());
        bool found = false;
        for (int i = int.Parse(m); i >= 1; i--)
        {
            for (int y = int.Parse(n); y >= 1; y--)
            {
                for (int z = int.Parse(l); z >= 1; z--)
                {
                    int currentNum = int.Parse(i.ToString() + y.ToString() + z.ToString());

                    if (currentNum % 3 == 0)
                    {
                        special += 5;
                    }
                    else if (currentNum % 10 == 5)
                    {
                        special -= 2;
                    }
                    else if (currentNum % 2 == 0)
                    {
                        special *= 2;
                    }

                    if (special >= control)
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }
            if (found)
            {
                break;
            }
        }

        if (found)
        {
            Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", special);
        }
        else
        {
            Console.WriteLine("No! {0} is the last reached special number.", special);
        }
    }
}