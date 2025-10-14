using System;

public class PictureBook : Book
{
    private string _illustrator;

    public void SetIll(string illustrator)
    {
        _illustrator = illustrator;
    }

    public string GetIll()
    {
        return _illustrator;
    }

    public void DisplayPictureBook()
    {
        Console.WriteLine($"Name:{_name}");
        Console.WriteLine($"Author:{_author}");
        Console.WriteLine($"illustrated:{_illustrator}");
    }
}