using System;

public class Blind
{
/*     private double _height;
    private double _width;
    private string _color;
 */
    public double Height {get; set;}
    public double Width {get; set;}
    public string Color {get; set;}

    public void Display()
    {
        Console.WriteLine($"Height:{Height}");
        Console.WriteLine($"Width: {Width}");
        Console.WriteLine($"Colour: {Color}");
    }

    /* public Blind (double height, double width, string color)
    {
        _height = height;
        _width = width;
        _color = color;
    }

    public double GetArea()
    {
        return _height * _width;
    } */

}

