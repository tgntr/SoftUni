using System;

class SpecialNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool firstDigit = false;
        bool secondDigit = false;
        bool thirdDigit = false;
        bool fourthDigit = false;
        for (int first = 1; first < 9; first++)
        {
            for (int second = 1; second < 9; second++)
            {
                for (int third = 1; third < 9; third++)
                {
                    for (int fourth = 1; fourth < 9; fourth++)
                    {
                        firstDigit = n % first == 0;
                        secondDigit = n % second == 0;
                        thirdDigit = n % third == 0;
                        fourthDigit = n % fourth == 0;
                        if (firstDigit && secondDigit && thirdDigit && fourthDigit) Console.Write("{0}{1}{2}{3} ", first, second, third, fourth);
                    }
                }
            }
        }
    }
}