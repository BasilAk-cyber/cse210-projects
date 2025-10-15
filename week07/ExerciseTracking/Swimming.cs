using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int min, int laps) : base(date, min)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50.0 / 1000 * 0.62; 
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _min) * 60;
    }

    public override double GetPace()
    {
        return _min / GetDistance();
    }
}