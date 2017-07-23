using System;

class Hotel
{
    static void Main()
    {
        string month = Console.ReadLine().ToLower();
        int nights = int.Parse(Console.ReadLine());
        double priceStudio = 0;
        double priceDouble = 0;
        double priceMaster = 0;
        bool freeNight = false;
        if (month == "may" || month == "october")
        {
            priceStudio = 50;
            priceDouble = 65;
            priceMaster = 75;
            if (nights > 7)
            {
                priceStudio *= 0.95;
            }
            if (month == "october" && nights > 7)
            {
                freeNight = true;
            }
        }
        else if (month == "june" || month == "september")
        {
            priceStudio = 60;
            priceDouble = 72;
            priceMaster = 82;
            if (nights > 14)
            {
                priceDouble *= 0.9;
            }
            if (month == "september" && nights > 7)
            {
                freeNight = true;
            }
        }
        else
        {
            priceStudio = 68;
            priceDouble = 77;
            priceMaster = 89;
            if (nights > 14)
            {
                priceMaster *= 0.85;
            }
        }

        if (freeNight)
        {
            priceStudio *= nights - 1;
        }
        else
        {
            priceStudio *= nights;
        }
        priceDouble *= nights;
        priceMaster *= nights;
        Console.WriteLine("Studio: {0:F2} lv. \nDouble: {1:F2} lv. \nSuite: {2:F2} lv.", priceStudio, priceDouble, priceMaster);
    }
}
