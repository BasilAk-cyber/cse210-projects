using System;

public class Video
{
    public string _title = "";
    public string _author  = "";
    public int _length = 0;
    public List<Comment> _comment = new List<Comment>();

    public int NumberOfComment()
    {
        return _comment.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine();
        Console.WriteLine($"Comments({NumberOfComment()})...");
        Console.WriteLine();

        foreach (Comment comment in _comment)
        {
            comment.Display();
        }

        Console.WriteLine();
    }

    /* public void AddComment(Comment comment)
    {
        _comment.Add(comment);
    }
 */
}