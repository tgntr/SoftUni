using System;

class DrawFort
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());

		string roofCarets = new string('^', n / 2);
		string ground = new string('_', n / 2);
		string dashesMid = new string('_', (n * 2) - 4 - (2 * (n / 2)));
		string roof = '/' + roofCarets + '\\' + dashesMid + '/' + roofCarets + '\\';
		string foundation = '\\' + ground + '/' + new string(' ', (n * 2) - 4 - (2 * (n / 2))) + '\\' + ground + '/';
		string foundationSpace = new string (' ', 1+(n/2));
		string foundationWalls = '|' + foundationSpace + dashesMid + foundationSpace + '|';
		string midSpace = new string (' ', (n*2) - 2);
		string walls = '|' + midSpace + '|';
		for (int i = 1; i <= n; i++)
		{
			if (i == 1) Console.WriteLine(roof);
			else if (i == n) Console.WriteLine(foundation);
			else if (i == n - 1) Console.WriteLine(foundationWalls);
			else Console.WriteLine(walls);
		}
	}
}
