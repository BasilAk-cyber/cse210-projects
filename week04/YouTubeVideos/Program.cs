using System;

class Program
{
    static void Main(string[] args)
    {

        Comment comment1 = new Comment();
        comment1._name = "John";
        comment1._text = "I feel inspired";

        Comment comment2 = new Comment();
        comment2._name = "Mark";
        comment2._text = "Love you guys sm";

        Comment comment3 = new Comment();
        comment3._name = "Regina";
        comment3._text = "Cute";

        Comment comment4 = new Comment();
        comment4._name = "Daniel";
        comment4._text = "Hii!";

        Comment comment5 = new Comment();
        comment5._name = "Phil";
        comment5._text = "";

        Comment comment6 = new Comment();
        comment6._name = "Omar";
        comment6._text = "";

        Comment comment7 = new Comment();
        comment7._name = "Linda";
        comment7._text = "";

        Comment comment8 = new Comment();
        comment8._name = "John";
        comment8._text = "";

        Comment comment9 = new Comment();
        comment9._name = "Chloe";
        comment9._text = "";

        Comment comment10 = new Comment();
        comment10._name = "Kelly";
        comment10._text = "";

        Comment comment11 = new Comment();
        comment11._name = "Vincent";
        comment11._text = "";

        Comment comment12 = new Comment();
        comment12._name = "Deborah";
        comment12._text = "";

        Comment comment13 = new Comment();
        comment13._name = "Cynthia";
        comment13._text = "";

        Comment comment14 = new Comment();
        comment14._name = "Clinton";
        comment14._text = "";

        Comment comment15 = new Comment();
        comment15._name = "Miracle";
        comment15._text = "";

        Comment comment16 = new Comment();
        comment16._name = "Joey";
        comment16._text = "";


        Video video1 = new Video();
        video1._title = "Ever After High";
        video1._author = "John Ginn";
        video1._length = 3000;
        video1._comment.Add(comment1);
        video1._comment.Add(comment2);
        video1._comment.Add(comment3);
        video1._comment.Add(comment4);
        
        Video video2 = new Video();
        video2._title = "";
        video2._author = "";
        video2._length = 0;
        video2._comment.Add(comment5);
        video2._comment.Add(comment6);
        video2._comment.Add(comment7);
        video2._comment.Add(comment8);

        Video video3 = new Video();
        video3._title = "";
        video3._author = "";
        video3._length = 0;
        video3._comment.Add(comment9);
        video3._comment.Add(comment10);
        video3._comment.Add(comment11);
        video3._comment.Add(comment12);

        Video video4 = new Video();
        video4._title = "";
        video4._author = "";
        video4._length = 0;
        video4._comment.Add(comment13);
        video4._comment.Add(comment14);
        video4._comment.Add(comment15);
        video4._comment.Add(comment16);

        video1.Display();


    }
}