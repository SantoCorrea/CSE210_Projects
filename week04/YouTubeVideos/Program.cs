using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        //Video 1
        Video video1 = new Video("How to learn C# in 2026", "Dev Channel", 600);
        video1.AddComment(new Comment("Anna", "Best tutorial in youtube, i've learned so much!"));
        video1.AddComment(new Comment("Victor", "This video helped me a lot, thanks!"));
        video1.AddComment(new Comment("James","Thanks for this great video man, this topic is really good."));
        videos.Add(video1);

        //Video 2
        Video video2 = new Video("How to understand functions in Python","TechMaster", 750);
        video2.AddComment(new Comment("Mark", "This is so helpful, thanks for the video"));
        video2.AddComment(new Comment("Nick", "I will put this in practice, great video"));
        video2.AddComment(new Comment("Linda","This topic was so great i loved this video!"));
        videos.Add(video2);

        //Video 3
        Video video3 = new Video("How to use loops in C++","Coding Machine", 890);
        video3.AddComment(new Comment("Vicent", "It was difficult for me to understand but know i feeling that i finally can understand"));
        video3.AddComment(new Comment("Laura", "Sending this to my entire class"));
        video3.AddComment(new Comment("Julia", "Perfect explanation!"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title:    {video.Title}");
            Console.WriteLine($"Author:   {video.Author}");
            Console.WriteLine($"Lenght:   {video.Length}");
            Console.WriteLine($"Comments:   {video.GetNumberOfComments()}");
            Console.WriteLine("--- Comments ---");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"   {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}