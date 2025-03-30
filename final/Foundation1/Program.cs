using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video v1 = new Video("Fonzi", "120", "arthur");
        Video v2 = new Video("Lime", "10", "Ludwig");
        v1.AddComment("Pat", "great vid");
        v2.AddComment("matt", "like!");
        v2.AddComment("andrew", "typical rage bait");

        videos.Add(v1);
        videos.Add(v2);
        foreach (Video video in videos)
        {
            video.Display();
        }

    }
}