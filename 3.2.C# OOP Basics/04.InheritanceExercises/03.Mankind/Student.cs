using System;
using System.Linq;

public class Student
    : Human
{
    private string facultyNumber;

    public string FacultyNumber
    {
        get
        {
            return facultyNumber;
        }
        set
        {
            if (value.Length < 5 || value.Length > 10 || value.Any(c=>!char.IsDigit(c) && !char.IsLetter(c)))
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            facultyNumber = value;
        }
    }

    public Student(string firstName, string lastName, string facultyNumber)
        :base (firstName, lastName)
    {
        FacultyNumber = facultyNumber;
    }

    public override string ToString()
    {
        return base.ToString() + $"Faculty number: {FacultyNumber}";
    }
}
