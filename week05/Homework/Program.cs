using System;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.SetName("Greate Book");
        book1.SetAuthor("Timothy Catagne");

        book1.DisplayBook();

        PictureBook book2 = new PictureBook();
        book2.SetName("Another book");
        book2.SetAuthor("Another book author");
        book2.SetIll("Book 2 Illustrator");

        book2.DisplayPictureBook();

    }
}