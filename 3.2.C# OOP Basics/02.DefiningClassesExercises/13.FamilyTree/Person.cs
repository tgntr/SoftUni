using System;
using System.Collections.Generic;

public class Person
{
    public string Name { get; set; }

    public string Birthday { get; set; }

    public List<Person> Parents { get; set; }

    public List<Person> Children { get; set; }

    public Person()
    {
        Parents = new List<Person>();

        Children = new List<Person>();
    }

    public Person (string input)
        :this()
    {

        var details = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < 3; i++)
        {
            if (details[i].Contains("/"))
            {
                Birthday = details[i];
            }
            else
            {
                Name += $"{details[i]} ";
            }
        }
        Name = Name.Trim();
    }

    public void PrintPerson()
    {
        Console.WriteLine($"{Name} {Birthday}\nParents:{string.Join("", Parents)}\nChildren:{string.Join("", Children)}");
    }

    public override string ToString()
    {
        if (Name == "")
            return "";
        return $"\n{Name} {Birthday}";
    }
}
