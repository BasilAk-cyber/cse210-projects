using System;

public class Blind
{
    public double _height;
    public double _width;
    public string _color;

    public void Display()
    {
        Console.WriteLine($"Height:{_height}");
        Console.WriteLine($"Width: {_width}");
        Console.WriteLine($"Colour: {_color}");
    }

    public Blind (double height, double width, string color)
    {
        _height = height;
        _width = width;
        _color = color;
    }

    public double GetArea()
    {
        return _height * _width;
    }

}

