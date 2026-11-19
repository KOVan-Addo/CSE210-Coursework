
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the first video
        Video video1 = new Video(
            "Introduction to C# Programming",
            "Programming with Mosh",
            720
        );

        video1.AddComment(new Comment("Kelvin", "Great introduction to C#!"));
        video1.AddComment(new Comment("Bella", "This made programming easier to understand."));
        video1.AddComment(new Comment("Belvin", "Very clear explanation."));
        video1.AddComment(new Comment("W.S", "Looking forward to more tutorials!"));

        // Create the second video
        Video video2 = new Video(
            "Understanding Object-Oriented Programming",
            "freeCodeCamp",
            1800
        );

        video2.AddComment(new Comment("Awura Ama", "OOP finally makes sense!"));
        video2.AddComment(new Comment("Lizzy", "The examples were very helpful."));
        video2.AddComment(new Comment("Franca", "I learned a lot from this video."));
        video2.AddComment(new Comment("Michael", "Excellent teaching!"));

        // Create the third video
        Video video3 = new Video(
            "Learn HTML and CSS for Beginners",
            "Traversy Media",
            2400
        );

        video3.AddComment(new Comment("Daniel", "This is a great starting point."));
        video3.AddComment(new Comment("Linda", "I love how practical this tutorial is."));
        video3.AddComment(new Comment("James", "Very informative and easy to follow."));
        video3.AddComment(new Comment("Grace", "Thank you for sharing this!"));

        // Create the fourth video
        Video video4 = new Video(
            "Introduction to Python Programming",
            "Corey Schafer",
            1500
        );

        video4.AddComment(new Comment("Joseph", "Python looks interesting!"));
        video4.AddComment(new Comment("Esther", "This tutorial is beginner-friendly."));
        video4.AddComment(new Comment("Samuel", "Well explained from start to finish."));
        video4.AddComment(new Comment("Rebecca", "I will definitely recommend this."));

        // Put all videos into a list
        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3,
            video4
        };

        // Display information about each video
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.GetDisplayText()}");
            }

            Console.WriteLine();
        }
    }
}
