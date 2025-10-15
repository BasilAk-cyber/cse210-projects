using System;

public abstract class Activity
{
    private DateTime _date;
    protected int _min;

    public Activity(DateTime date, int min)
    {
        _date = date;
        _min = min;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace(); 

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_min} min)- Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}