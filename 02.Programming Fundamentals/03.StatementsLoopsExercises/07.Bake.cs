using System;

class Bake
{
    static void Main()
    {
        bool bake = false;
        int count = 0;
        while (bake == false)
        {
            string ingredient = Console.ReadLine();
            
            if (ingredient == "Bake!")
            {
                bake = true;
                Console.WriteLine("Preparing cake with {0} ingredients.", count);
            }
            else
            {
                Console.WriteLine("Adding ingredient {0}.", ingredient);
                count++;
            }
        }
    }
}
