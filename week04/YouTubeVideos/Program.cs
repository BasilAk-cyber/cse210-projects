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

        // Create comments for video 2
        Comment comment5 = new Comment();
        comment5._name = "Phil";
        comment5._text = "This is so helpful, thanks!";

        Comment comment6 = new Comment();
        comment6._name = "Omar";
        comment6._text = "Great content";

        Comment comment7 = new Comment();
        comment7._name = "Linda";
        comment7._text = "I learned so much from this";

        Comment comment8 = new Comment();
        comment8._name = "Sarah";
        comment8._text = "Amazing work!";

        // Create comments for video 3
        Comment comment9 = new Comment();
        comment9._name = "Chloe";
        comment9._text = "Very informative video";

        Comment comment10 = new Comment();
        comment10._name = "Kelly";
        comment10._text = "Can you make more videos like this?";

        Comment comment11 = new Comment();
        comment11._name = "Vincent";
        comment11._text = "Excellent explanation";

        Comment comment12 = new Comment();
        comment12._name = "Deborah";
        comment12._text = "Subscribed!";

        // Create comments for video 4
        Comment comment13 = new Comment();
        comment13._name = "Cynthia";
        comment13._text = "This helped me a lot";

        Comment comment14 = new Comment();
        comment14._name = "Clinton";
        comment14._text = "Keep up the good work";

        Comment comment15 = new Comment();
        comment15._name = "Miracle";
        comment15._text = "Best tutorial ever";

        Comment comment16 = new Comment();
        comment16._name = "Joey";
        comment16._text = "Thanks for sharing";

        Video video1 = new Video();
        video1._title = "Ever After High";
        video1._author = "John Ginn";
        video1._length = 3000;
        video1._comment.Add(comment1);
        video1._comment.Add(comment2);
        video1._comment.Add(comment3);
        video1._comment.Add(comment4);
        
         Video video2 = new Video();
        video2._title = "Python Programming for Beginners";
        video2._author = "Tech Academy";
        video2._length = 1800;
        video2._comment.Add(comment5);
        video2._comment.Add(comment6);
        video2._comment.Add(comment7);
        video2._comment.Add(comment8);

        // Create video 3
        Video video3 = new Video();
        video3._title = "Cooking Pasta the Italian Way";
        video3._author = "Chef Maria";
        video3._length = 900;
        video3._comment.Add(comment9);
        video3._comment.Add(comment10);
        video3._comment.Add(comment11);
        video3._comment.Add(comment12);

        // Create video 4
        Video video4 = new Video();
        video4._title = "Morning Yoga Routine";
        video4._author = "Wellness Studio";
        video4._length = 1200;
        video4._comment.Add(comment13);
        video4._comment.Add(comment14);
        video4._comment.Add(comment15);
        video4._comment.Add(comment16);

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Iterate through the list and display each video
        foreach (Video video in videos)
        {
            video.Display();
        }


    }
}