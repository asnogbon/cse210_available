using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>
        {
            new Video(
                "Running Team",
                "Ashogbon Toluwanimi",
                "10:30",
                new List<Comment>
                {
                    new Comment("Michael Johnson: Your perspective on this issue is refreshing. Subscribed for more!"),
                    new Comment("Olivia Brown: Such a beautiful message. Thank you for sharing this video with us. It really touched my heart."),
                    new Comment("Ethan Garcia: The way you explained that concept made it so easy to understand. Thank you!"),
                    new Comment("Ava Martinez: I always look forward to your uploads. You never disappoint! Keep up the amazing work!"),
                }
            ),
            new Video(
                "Check A Team",
                "Ashogbon Toluwanimi",
                "19:30",
                new List<Comment>
                {
                    new Comment("Emily Roberts: Absolutely loved this video! The editing was top-notch!"),
                    new Comment("James Thompson: This topic is so relevant right now. Great insights! Keep it up!"),
                    new Comment("Sophia Lee: I can't stop laughing at the video! The humor is on point, and the timing is perfect. Subscribed for more content like this!"),
                    new Comment("Michael Johnson: This video is a game-changer! The information provided is incredibly valuable"),
                }
            ),
            new Video(
                "Eating Team",
                "Ashogbon Toluwanimi",
                "1:58:4",
                new List<Comment>
                {
                    new Comment("Ashogbon Toluwanimi: it is a good video"),
                    new Comment("Aisah Toluwola: it is a bad video"),
                    new Comment("Azizat Golry: it is a nice video"),
                }
            ),
            new Video(
                "Chossen Ones",
                "Ashogbon Toluwanimi",
                "30",
                new List<Comment>
                {
                    new Comment("Isabella Wilson: This was exactly what I needed today. You always know how to inspire!"),
                    new Comment("Liam Davis: Your dedication to creating quality content is evident in every video. Keep up the great work!"),
                    new Comment("Liam Anderson: Your humor makes learning so much fun! More videos, please!"),
                    new Comment("Ava Jackson: The visuals in this video were stunning! You have a great eye for detail"),
                }
            ),
        };

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetVideo());

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment);
            }

            Console.WriteLine($"This video has {video.GetCommentCount()} comments.");
            Console.WriteLine();
        }
    }
}
