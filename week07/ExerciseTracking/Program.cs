using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _gymActivity = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0), // 3 miles
            new Cycling(new DateTime(2022, 11, 3), 30, 12.0), // 12 mph
            new Swimming(new DateTime(2022, 11, 3), 30, 20) // 20 laps
        };

        foreach (Activity act in _gymActivity)
        {
            Console.WriteLine(act.GetSummary());
        }
    }
}