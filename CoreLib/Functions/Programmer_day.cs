namespace CoreLib;

public class Programmer_day
{
    // Check if the day is a programmer's day == 13.09.2023 or 12.09.2024
    public static Func<DateTime, bool> isDayOfYear256 = date => date.DayOfYear == 256;
}