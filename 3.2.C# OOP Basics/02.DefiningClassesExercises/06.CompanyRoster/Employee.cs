using System;

public class Employee
{
    public string Name { get; set; }

    public decimal Salary { get; set; }

    public string Position { get; set; }

    public string Department { get; set; }

    public string Email { get; set; }

    public int Age { get; set; }

    public Employee()
    {
        Age = -1;
        Email = "n/a";
    }

    

    public Employee(string input)
        :this()
    {
        var employeeDetails = input.Split();

        Name = employeeDetails[0];

        Salary = decimal.Parse(employeeDetails[1]);

        Position = employeeDetails[2];

        Department = employeeDetails[3];

        var index = 4;
        var detailsCount = employeeDetails.Length;
        while (index < detailsCount)
        {
            if (int.TryParse(employeeDetails[index], out int age))
                Age = age;
            else
                Email = employeeDetails[index];
            index++;
        }
    }

    public override string ToString()
    {
        return $"{Name} {Salary:F2} {Email} {Age}";
    }


}
