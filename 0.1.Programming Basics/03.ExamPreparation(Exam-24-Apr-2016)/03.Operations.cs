using System;

class Operations
{
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        double result = 0;
        char inputOperator = char.Parse(Console.ReadLine());
        if (n2 == 0 && (inputOperator == '/' || inputOperator == '%'))
        {
            if (n1 == 0 || n2 == 0) Console.WriteLine("Cannot divide {0} by zero", n1);
        }
        else if (inputOperator == '-' || inputOperator == '+' || inputOperator == '*')
        {
            if (inputOperator == '-')
            {
                result = n1 - n2;
            }
            if (inputOperator == '+')
            {
                result = n1 + n2;
            }
            if (inputOperator == '*')
            {
                result = n1 * n2;
            }
            string isEven = "";
            if (result % 2 == 0)
            {
                isEven = "even";
            }
            else isEven = "odd";
            Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, inputOperator, n2, (int)result, isEven);
        }
        else if (inputOperator == '/')
        {
            result = (double)n1 / n2;
            Console.WriteLine("{0} {1} {2} = {3:F2}", n1, inputOperator, n2, result);

        }
        else if (inputOperator == '%')
        {
            Console.WriteLine("{0} {1} {2} = {3}", n1, inputOperator, n2, n1 % n2);

        }

    }
}