using System;

public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int min, double Distance) : base(date, min)
    {
        _distance = Distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _min) * 60;
    }

    public override double GetPace()
    {
        return _min / _distance;
    }
}