using System;
using System.Globalization;

public class DateModifier
{
    public DateTime FirstDate { get; set; }
    public DateTime SecondDate { get; set; }

    public DateModifier(string first, string second)
    {
        FirstDate = DateTime.ParseExact(first, "yyyy MM dd", CultureInfo.InvariantCulture);
        SecondDate = DateTime.ParseExact(second, "yyyy MM dd", CultureInfo.InvariantCulture);
    }

    public int DaysBetween()
    {
        return (int)Math.Abs((FirstDate - SecondDate).TotalDays);
    }
}
