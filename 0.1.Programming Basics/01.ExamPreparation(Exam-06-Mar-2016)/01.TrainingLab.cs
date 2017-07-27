using System;

class TrainingLab
{
	static void Main()
	{
		double h = double.Parse(Console.ReadLine());
		double w = double.Parse(Console.ReadLine());
		int desks = (int)((w * 100) - 100) / 70;
		int chairs = (int)(h * 100) / 120;
		int workingPlaces = (desks * chairs) - 3;
		Console.WriteLine(workingPlaces);
	}
}
