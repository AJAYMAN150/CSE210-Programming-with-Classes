using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learning dance", "Dance-a-mania", 600);
        Video video2 = new Video("How to snap", "Basic Beth", 100);
        Video video3 = new Video("Travelling to China", "Passport Paul", 1200);

        video1.AddComment(new Comment("Jake", "You taught me how to Dougie!"));
        video1.AddComment(new Comment("Bob", "So THAT'S the macarena."));
        video1.AddComment(new Comment("Molly", "Instructions unclear, I learned how to sing instead."));

        video2.AddComment(new Comment("Dave", "Oh, well now I know."));
        video2.AddComment(new Comment("Eve", "I'm ashamed I didn't know this sooner."));

        video3.AddComment(new Comment("Frank", "China looks amazing!"));
        video3.AddComment(new Comment("Grace", "I want to visit China someday."));
        video3.AddComment(new Comment("Hank", "Great video, thanks for sharing!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}
