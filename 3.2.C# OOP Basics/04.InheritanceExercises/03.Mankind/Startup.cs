using System;

class Startup
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();

        var studentFirstName = input[0];
        var studentLastName = input[1];
        var facultyNumber = input[2];

        input = Console.ReadLine().Split();

        var workerFirstName = input[0];
        var workerLastName = input[1];
        var workerSalary = decimal.Parse(input[2]);
        var workingHours = decimal.Parse(input[3]);

        try
        {
            var student = new Student(studentFirstName, studentLastName, facultyNumber);
            var worker = new Worker(workerFirstName, workerLastName, workerSalary, workingHours);
            Console.WriteLine($"{student}\n\n{worker}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
