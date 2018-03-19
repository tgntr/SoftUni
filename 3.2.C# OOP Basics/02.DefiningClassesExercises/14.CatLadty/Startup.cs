using System;
using System.Collections.Generic;
using System.Linq;

class Startup
{
    static void Main()
    {
        var ladyCats = new List<Cat>();

        var input = "";
        while ((input = Console.ReadLine()) != "End")
        {
            var type = input.Split()[0];

            if (type == "Siamese")
            {
                ladyCats.Add(new SiameseCat(input));
            }
            else if (type == "Cymric")
            {
                ladyCats.Add(new CymricCat(input));
            }
            else
            {
                ladyCats.Add(new StreetExtraordinaireCat(input));
            }
        }

        var cat = Console.ReadLine();

        Console.WriteLine(ladyCats.Where(c=>c.Name == cat).First());
    }
}
