using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        byte age = byte.Parse(Console.ReadLine());
        char gender = Convert.ToChar(Console.ReadLine());
        long personalID = long.Parse(Console.ReadLine());
        int employeeID = int.Parse(Console.ReadLine());
        Console.WriteLine("First name: {0} \nLast name: {1} \nAge: {2} \nGender: {3} \nPersonal ID: {4} \nUnique Employee number: {5}", 
            firstName, lastName, age, gender, personalID, employeeID);
    }
}
