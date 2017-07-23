using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string save = "";
        bool balanced = true;

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine().Trim();
            if (input == "(" || input == ")")
            {
                save += input;
                if((save.Length % 2 == 1 && save[save.Length - 1] == ')') || (save.Length % 2 == 0 && save[save.Length - 1] == '('))
                {
                   
                    balanced = false;
                }
            }
        }
        if (balanced && save.Length % 2 == 0)
        {
            Console.WriteLine("BALANCED");
        }
        else
        {
            Console.WriteLine("UNBALANCED");
        }
    }
}
