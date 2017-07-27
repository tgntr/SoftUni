using System;

class OnTimeForTheExam
{
	static void Main()
	{
		int examHour = int.Parse(Console.ReadLine());
		int examMin = int.Parse(Console.ReadLine());
		int arrivalHour = int.Parse(Console.ReadLine());
		int arrivalMin = int.Parse(Console.ReadLine());
		int diff = 0;   
		 
		if (arrivalHour > examHour || (arrivalHour == examHour && arrivalMin > examMin))
		{
			if (arrivalHour > examHour)
				diff = Math.Abs((arrivalHour - (examHour + 1))) * 60 + (60 - examMin) + arrivalMin;
			else diff = arrivalMin - examMin;
			Console.WriteLine("Late");
			if (diff > 59)
			{
				Console.WriteLine("{0}:{1:00} hours after the start", diff / 60, diff % 60);
			}
			else Console.WriteLine("{0} minutes after the start", diff);
		}
		else
		{
			if (arrivalHour < examHour)
				diff = Math.Abs(((arrivalHour + 1) - examHour)) * 60 + (60 - arrivalMin) + examMin;
			else diff = examMin - arrivalMin;
			if (diff > 59)
			{
				Console.WriteLine("Early");
				Console.WriteLine("{0}:{1:00} hours before the start", diff / 60, diff % 60);
			}
			else if (diff > 30)
			{
				Console.WriteLine("Early");
				Console.WriteLine("{0} minutes before the start", diff);
			}
			else if (diff == 0) Console.WriteLine("On time");
			else 
			{
				Console.WriteLine("On time");
				Console.WriteLine("{0} minutes before the start", diff);
			}
		}
		
	}
}
