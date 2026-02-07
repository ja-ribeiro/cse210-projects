using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        //videos
        Video video1 = new Video("Understading C#", "Tech Write", 1800);
        Video video2 = new Video("The difference between Encapsulations and Abstraction", "Code Alone", 900);
        Video video3 = new Video("Tips for new programmers", "DevWorld", 1200);

        //comments - video1
        video1.AddComment(new Comment("Anna", "This video helped me a lot, thank you!!"));
        video1.AddComment(new Comment("Luke", "I always learn something new"));
        video1.AddComment(new Comment("Bob", "Very well explained"));

        //comments - video2
        video2.AddComment(new Comment("Ethan", "Now I got it!"));
        video2.AddComment(new Comment("Diana", "Another amazing video"));
        video2.AddComment(new Comment("Eleonor", "Straigth to the point"));

        //comments - video3
        video3.AddComment(new Comment("Gabriel", "Great Tips!"));
        video3.AddComment(new Comment("Fernanda", "Nice examples"));
        video3.AddComment(new Comment("Susan", "Well done!"));

        //List of videos
        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3
        };

        // Display video inf
        foreach (Video video in videos)
        {
            Console.WriteLine("=================================");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}