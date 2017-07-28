using System;

class TrainersSalary
{
    static void Main()
    {
        int total = int.Parse(Console.ReadLine());
        double budget = double.Parse(Console.ReadLine());
        int Jelev = 0;
        int RoYaL = 0;
        int Roli = 0;
        int Trofon = 0;
        int Sino = 0;
        int others = 0;
        for (int i = 0; i < total; i++)
        {
            string name = Console.ReadLine();
            if (name == "Jelev") Jelev++;
            else if (name == "RoYaL") RoYaL++;
            else if (name == "Trofon") Trofon++;
            else if (name == "Roli") Roli++;
            else if (name == "Sino") Sino++;
            else others++;
        }
        double salary = budget / total;
        Console.WriteLine("Jelev salary: {0:F2} lv \nRoYaL salary: {1:F2} lv \nRoli salary: {2:F2} lv" +
            "\nTrofon salary: {3:F2} lv \nSino salary: {4:F2} lv \nOthers salary: {5:F2} lv",
            Jelev * salary, RoYaL * salary, Roli * salary, Trofon * salary, Sino * salary, others * salary);

    }
}
