using System;

public class Worker
    :Human
{
    private decimal salary;
    private decimal workingHours;


    public Worker(string firstName, string lastName, decimal salary, decimal workingHours)
        : base(firstName, lastName)
    {
        Salary = salary;
        WorkingHours = workingHours;
    }


    public decimal Salary
    {
        get
        {
            return salary;
        }
        set
        {
            if (value <= 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }

            salary = value;
        }
    }
    
    public decimal WorkingHours
    {
        get
        {
            return workingHours;
        }
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }

            workingHours = value;
        }
    }

    public decimal SalaryPerHour => Salary / WorkingHours / 5;
    

    public override string ToString()
    {
        return base.ToString() + $"Week Salary: {Salary:F2}\nHours per day: {WorkingHours:F2}\nSalary per hour: {SalaryPerHour:F2}";
    }
}
