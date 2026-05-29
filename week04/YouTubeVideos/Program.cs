using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> video = new List<string>
        {
            "Running Team,Ashogbon Toluwanimi,10:30",
            "Check A Team,Ashogbon Toluwanimi,19:30",
            "Eating Team,Ashogbon Toluwanimi,1:58:4",
            "Chossen Ones,Ashogbon Toluwanimi,30",
        };
        
        int count = 0;

        foreach (string word in video)
        {
            Video entry = new Video();
            Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
            Console.WriteLine(entry._GetVideo(word));
            count++;

            if (count == 1)
            {
                List<string> commt = new List<string>
                {
                    "Michael Johnson: Your perspective on this issue is refreshing. Subscribed for more! ",
                    "Olivia Brown: Such a beautiful message. Thank you for sharing this video with us. It really touched my heart.",
                    "Ethan Garcia: The way you explained that concept made it so easy to understand. Thank you!",
                    "Ava Martinez: I always look forward to your uploads. You never disappoint! Keep up the amazing work!",
                };
                string commentCount = commt.Count.ToString();
                foreach (string comment in commt)
                {
                    Comment commentEntry = new Comment();
                    Console.WriteLine(commentEntry._GetComment(comment));
                }
                Console.WriteLine($"This video has {commentCount} comments.");
                Console.WriteLine("");
            }
            else if (count == 2)
            {
                List<string> commt = new List<string>
                {
                    "Emily Roberts: Absolutely loved this video! The editing was top-notch!",
                    "James Thompson: This topic is so relevant right now. Great insights! Keep it up!",
                    "Sophia Lee: I can't stop laughing at the video! The humor is on point, and the timing is perfect. Subscribed for more content like this!",
                    "Michael Johnson: This video is a game-changer! The information provided is incredibly valuable",
                };
                string commentCount = commt.Count.ToString();
                foreach (string comment in commt)
                {
                    Comment commentEntry = new Comment();
                    Console.WriteLine(commentEntry._GetComment(comment));
                }
                Console.WriteLine($"This video has {commentCount} comments.");
                Console.WriteLine("");
            }
            else if (count == 3)
            {
                List<string> commt = new List<string>
                {
                    "Ashogbon Toluwanimi: it is a good video",
                    "Aisah Toluwola: it is a bad video",
                    "Azizat Golry: it is a nice video",
                };
                string commentCount = commt.Count.ToString();
                foreach (string comment in commt)
                {
                    Comment commentEntry = new Comment();
                    Console.WriteLine(commentEntry._GetComment(comment));
                }
                Console.WriteLine($"This video has {commentCount} comments.");
                Console.WriteLine("");
            }
            else if (count == 4)
            {
                List<string> commt = new List<string>
                {
                    "Isabella Wilson: This was exactly what I needed today. You always know how to inspire!",
                    "Liam Davis: Your dedication to creating quality content is evident in every video. Keep up the great work!",
                    "Liam Anderson: Your humor makes learning so much fun! More videos, please!",
                    "Ava Jackson: The visuals in this video were stunning! You have a great eye for detail",
                };
                string commentCount = commt.Count.ToString();
                foreach (string comment in commt)
                {
                    Comment commentEntry = new Comment();
                    Console.WriteLine(commentEntry._GetComment(comment));
                }
                Console.WriteLine($"This video has {commentCount} comments.");
                Console.WriteLine("");
            }
        }
    }
}
