using System;

class PasswordGenerator
{
   static void Main()
   {
	   int maxDigit = int.Parse(Console.ReadLine());
	   int maxLetter = int.Parse(Console.ReadLine());
	   for (int firstDigit = 1; firstDigit < maxDigit; firstDigit++)
	   {
		   for (int secondDigit = 1; secondDigit < maxDigit; secondDigit++)
		   {
			   for (int firstLetter = 0; firstLetter < maxLetter; firstLetter++)
			   {
				   for (int secondLetter = 0; secondLetter < maxLetter; secondLetter++)
				   {
					   for (int lastDigit = Math.Max(firstDigit,secondDigit) + 1; lastDigit <= maxDigit; lastDigit++)
					   {
						   Console.Write("{0}{1}{2}{3}{4} ", firstDigit, secondDigit, (char)('a' + firstLetter), (char)('a' + secondLetter), lastDigit);
					   }
				   }
			   }
		   }
	   }
   }
}
