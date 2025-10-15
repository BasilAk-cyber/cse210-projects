using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int min, double Speed) : base(date, min)
    {
        _speed = Speed;
    }

    public override double GetDistance()
    {
        return (_speed * _min) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}