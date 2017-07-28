using System;

class WorkHours
{
    static void Main()
    {

        int hoursOfWork = int.Parse(Console.ReadLine());
        int employees = int.Parse(Console.ReadLine());
        int workingDays = int.Parse(Console.ReadLine());
        int workingHours = (workingDays * 8) * employees;
        int difference = Math.Abs(workingHours - hoursOfWork);

        if (workingHours >= hoursOfWork)
        {
            Console.WriteLine("{0} hours left", difference);
        }
        else
        {
            Console.WriteLine("{0} overtime \nPenalties: {1}", difference, difference * workingDays);
        }
    }
}

