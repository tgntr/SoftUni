using System;

class Restaurant
{
    static void Main()
    {
        int group = int.Parse(Console.ReadLine());
        string package = Console.ReadLine();
        string hall = "";
        double price = 0;
        bool limit = false;
        if (group <= 50)
        {
            price += 2500;
            hall = "Small Hall";
        }
        else if (group <= 100)
        {
            price += 5000;
            hall = "Terrace";
        }
        else if (group <= 120)
        {
            price += 7500;
            hall = "Great Hall";
        }
        else
        {
            limit = true;
            //Console.WriteLine("We do not have an appropriate hall.");
        }

        if (package == "Normal")
        {
            price = (price + 500) * 0.95;
        }
        else if (package == "Gold")
        {
            price = (price + 750) * 0.9;
        }
        else
        {
            price = (price + 1000) * 0.85;
        }
        
        if (limit)
        {
            Console.WriteLine("We do not have an appropriate hall.");
        }
        else
        {
            Console.WriteLine("We can offer you the {0} \nThe price per person is {1:F2}$", hall, price / group); 
        }
    }
}

