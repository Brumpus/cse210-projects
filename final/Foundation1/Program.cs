using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the foundation 1 project!");
        Video video1 = new Video("NoBitRate",26.02, "I built a life size sonic that can cut you in half");
        Comment commentA1 = new Comment("JimbusNimbus", "This video is so cool");
        video1.AddComment(commentA1);
        Comment commentA2 = new Comment("Steven123", "I liked the part where the TV got disintegrated.");
        video1.AddComment(commentA2);
        Comment commentA3 = new Comment("RealSteveHarvey", "HOLY MOLY!!!");
        video1.AddComment(commentA3);
        Comment extraComment = new Comment("Quinton Hogan", "I really liked this video, It's a real video and it's really funny");
        video1.AddComment(extraComment);
        video1.DisplayVideo();

        Video video2 = new Video("Game Theory", 10.50, "Why my videos aren't as good anymore");
        Comment commentB1 = new Comment("GameTheoryShill01", "No this is WRONG!!!");
        video2.AddComment(commentB1);
        Comment commentB2 = new Comment("RegularJames", "Yeah Game Theory really fell off...");
        video2.AddComment(commentB2);
        Comment commentB3 = new Comment("KJHGDKJHOHd1234", "Click here for a free !! giveaway  --> ");
        video2.AddComment(commentB3);
        video2.DisplayVideo();

        Video video3 = new Video("Mr. Beast", 100.03, "Building exo-suits for homeless people!");
        Comment commentC1 = new Comment("Fortnite", "This is a real cool video");
        video3.AddComment(commentC1);
        Comment commentC2 = new Comment("RealSteveHarvey", "Wow this is truly inspirational");
        video3.AddComment(commentC2);
        Comment commentC3 = new Comment("Steven123", "Wait did fortnite make that first comment?");
        video3.AddComment(commentC3);
        video3.DisplayVideo();




    }
}