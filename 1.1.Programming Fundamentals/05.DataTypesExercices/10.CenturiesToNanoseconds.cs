using System;
using System.Numerics;

class CenturiesToNanoseconds
{
    static void Main()
    {
        BigInteger centuries = BigInteger.Parse(Console.ReadLine());
        BigInteger years = centuries * 100;
        BigInteger days = (BigInteger)((double)years * 365.242d);
        BigInteger hours = (BigInteger)days * 24;
        BigInteger minutes = hours * 60;
        BigInteger seconds = minutes * 60;
        BigInteger milliSeconds = seconds * 1000;
        BigInteger microSeconds = milliSeconds * 1000;
        BigInteger nanoSeconds = microSeconds * 1000;
        Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = " +
            "{5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", centuries, years, 
            days, hours, minutes, seconds, milliSeconds, microSeconds, nanoSeconds);
    }
}
