using System;

class BPM
{
    static void Main()
    {
        decimal bpm = decimal.Parse(Console.ReadLine());
        decimal beats = decimal.Parse(Console.ReadLine());
        decimal bars = Math.Round(beats / 4, 1);
       
        decimal length = (beats * (60 / bpm));
        double mins = (int)length / 60;
        double secs = (int)length % 60;
        if (bars > (int)bars)
        {
            Console.WriteLine("{0:F1} bars - {1:F0}m {2:F0}s", bars, mins, secs);
        }
        else
        {
            Console.WriteLine("{0} bars - {1:F0}m {2:F0}s", bars, mins, secs);
        }
    }
}
