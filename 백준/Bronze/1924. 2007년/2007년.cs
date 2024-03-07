using System;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();
        var mon = Int32.Parse(input[0]);
        var day = Int32.Parse(input[1]);

        var date = new DateTime(2007, mon, day);

        var dayofWeek = date.DayOfWeek switch
        {
            DayOfWeek.Sunday => "SUN",
            DayOfWeek.Monday => "MON",
            DayOfWeek.Tuesday => "TUE",
            DayOfWeek.Wednesday => "WED",
            DayOfWeek.Thursday => "THU",
            DayOfWeek.Friday => "FRI",
            DayOfWeek.Saturday => "SAT",
            _ => "NONE",
        };

        Console.WriteLine(dayofWeek);
    }
}