using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Basics Tutorial", "Lifegates Channel", 600);
        video1.AddComment(new Comment("Lifegate Justice", "Great tutorial, thanks!"));
        video1.AddComment(new Comment("Jane Smith", "Very helpful, I learned a lot!"));
        video1.AddComment(new Comment("Alice Johnson", "Clear and concise, well done."));
        videos.Add(video1);

        Video video2 = new Video("Programming with Classes", "Tech Educator", 900);
        video2.AddComment(new Comment("Michael Brown", "OOP concepts are clearer now."));
        video2.AddComment(new Comment("Sarah Davis", "Good examples, but a bit fast."));
        video2.AddComment(new Comment("David Green", "Thanks for this explanation!"));
        videos.Add(video2);

        Video video3 = new Video("Abstraction and Encaspulation C# Techniques", "Pro Devs", 1200);
        video3.AddComment(new Comment("Emily White", "Can't wait to try this in my project."));
        video3.AddComment(new Comment("Robert Black", "A bit complex but useful."));
        video3.AddComment(new Comment("Jessica Blue", "Thanks for the detailed breakdown."));
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}