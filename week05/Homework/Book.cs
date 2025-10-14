using System;

public class Book
{
    protected string _name;
    protected string _author;

/*     public Book(string name, string author)
    {
        _name = name;
        _author = author;
    }
 */
    public void SetName(string name)
    {
        _name = name;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public void DisplayBook()
    {
        Console.WriteLine($"Name:{_name}");
        Console.WriteLine($"Author:{_author}");
    }
}
