using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Make Pancakes", "Jamie Oliver", 420);
        video1.AddComment(new Comment("Megan", "This recipe was easy to follow."));
        video1.AddComment(new Comment("Carlos", "My pancakes turned out great."));
        video1.AddComment(new Comment("Jenna", "I liked the clear instructions."));
        video1.AddComment(new Comment("Tyler", "I would watch another video like this."));

        Video video2 = new Video("Beginner Guitar Lesson", "Tom Strahle", 600);
        video2.AddComment(new Comment("Ryan", "This helped me learn my first chord."));
        video2.AddComment(new Comment("Ashley", "Great lesson for beginners."));
        video2.AddComment(new Comment("Sam", "Please make more guitar videos."));
        video2.AddComment(new Comment("Grace", "The examples made this easier to understand."));

        Video video3 = new Video("Top 5 Travel Tips", "Aly Smalls", 360);
        video3.AddComment(new Comment("Lily", "The packing tip was very helpful."));
        video3.AddComment(new Comment("Mark", "I wish I knew this before my last trip."));
        video3.AddComment(new Comment("Nora", "Good advice and easy to understand."));
        video3.AddComment(new Comment("Ben", "These tips are useful for first-time travelers."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine();

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine();
        }
    }
}