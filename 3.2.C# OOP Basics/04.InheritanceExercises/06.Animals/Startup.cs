using System;
using System.Collections.Generic;
using System.Linq;

class Startup
{
    static void Main()
    {
        var animals = new List<Animal>();
        var input = "";
        
        while ((input = Console.ReadLine()) != "Beast!")
        {
            try
            {
                var animal = input;
                input = Console.ReadLine();
                animals.Add(Animal.GetAnimal(animal, input));
                Console.WriteLine(animals.Last());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
