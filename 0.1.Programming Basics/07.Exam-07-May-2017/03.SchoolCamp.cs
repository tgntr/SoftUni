using System;

class SchoolCamp
{
    static void Main()
    {
        string season = Console.ReadLine();
        string gender = Console.ReadLine();
        int students = int.Parse(Console.ReadLine());
        int nights = int.Parse(Console.ReadLine());
        double price = 0;
        string sport = "";
        if (season == "Winter")
        {
            if (gender == "mixed")
            {
                price = 10;
                sport = "Ski";
            }
            else if (gender == "boys")
            {
                price = 9.6;
                sport = "Judo";
            }
            else
            {
                price = 9.6;
                sport = "Gymnastics";
            }
        }
        else if (season == "Spring")
        {
            if (gender == "mixed")
            {
                price = 9.5;
                sport = "Cycling";
            }
            else if (gender == "boys")
            {
                price = 7.2;
                sport = "Tennis";
            }
            else
            {
                price = 7.2;
                sport = "Athletics";
            }
        }
        else
        {
            if (gender == "mixed")
            {
                price = 20;
                sport = "Swimming";
            }
            else if (gender == "boys")
            {
                price = 15;
                sport = "Football";
            }
            else
            {
                price = 15;
                sport = "Volleyball";
            }
        }
        price = (students * price) * nights;
        if (students >= 50)
        {
            price = price - (0.5 * price);
        }
        else if (students >= 20)
        {
            price = price - (0.15 * price);
        }
        else if (students >= 10)
        {
            price = price - (0.05 * price);
        }
        Console.WriteLine("{0} {1:F2} lv.", sport, price);
    }
}