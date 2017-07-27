using System;

class Histogram
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		double p1 = 0d;
		double p2 = 0d;
		double p3 = 0d;
		double p4 = 0d;
		double p5 = 0d;
					 
		for (int i = 0; i < n; i++)
		{
			 int number = int.Parse(Console.ReadLine());
			 if (number < 200) p1++;
			 else if (number < 400) p2++;
			 else if (number < 600) p3++;
			 else if (number < 800) p4++;
			 else p5++;
		}
		Console.WriteLine("{0:F2}%", p1 / n * 100d);
		Console.WriteLine("{0:F2}%", p2 / n * 100d);
		Console.WriteLine("{0:F2}%", p3 / n * 100d);
		Console.WriteLine("{0:F2}%", p4 / n * 100d);
		Console.WriteLine("{0:F2}%", p5 / n * 100d);
	}
}

