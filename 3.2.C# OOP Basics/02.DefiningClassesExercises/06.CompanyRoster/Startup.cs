using System;
using System.Collections.Generic;
using System.Linq;

class Startup
{
    static void Main()
    {
        var employees = new List<Employee>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var employee = Console.ReadLine();

            employees.Add(new Employee(employee));
        }
        
        var departments = GroupByDepartment(employees);
        var topDepartment = GetTopDepartment(departments);

        Console.WriteLine($"Highest Average Salary: {topDepartment.Key}");
        Console.WriteLine(string.Join("\n", topDepartment.Value.OrderByDescending(e => e.Salary)));

    }

    private static KeyValuePair<string, List<Employee>> GetTopDepartment(Dictionary<string, List<Employee>> departments)
    {
        return departments
                    .OrderByDescending(d => d.Value.Average(e => e.Salary))
                    .First();
    }

    private static Dictionary<string, List<Employee>> GroupByDepartment(List<Employee> employees)
    {
        return employees
                    .GroupBy(e => e.Department)
                    .ToDictionary(g => g.Key, g => g.ToList());
    }
}
