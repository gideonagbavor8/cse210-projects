using System;
using System.Collections.Generic;

class Comment
{
    private string commenterName;
    private string text;

    public Comment(string commenterName, string text)
    {
        this.commenterName = commenterName;
        this.text = text;
    }

    public string GetCommenterName()
    {
        return commenterName;
    }

    public string GetText()
    {
        return text;
    }
}

class Video
{
    private string title;
    private string author;
    private int lengthInSeconds;
    private List<Comment> comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        this.title = title;
        this.author = author;
        this.lengthInSeconds = lengthInSeconds;
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public void DisplayComments()
    {
        foreach (var comment in comments)
        {
            Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
        }
    }

    public string GetVideoDetails()
    {
        return $"Title: {title}\nAuthor: {author}\nLength: {lengthInSeconds} seconds\nNumber of Comments: {GetNumberOfComments()}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Understanding Abstraction", "Gideon J.", 300);
        video1.AddComment(new Comment("Peace", "Great explanation!"));
        video1.AddComment(new Comment("Millicent", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Elinam", "I finally understand abstraction."));
        video1.AddComment(new Comment("Peter", "Clear and concise."));

        Video video2 = new Video("Introduction to Classes", "Agbotse Harrison", 450);
        video2.AddComment(new Comment("Elisha", "Nice video!"));
        video2.AddComment(new Comment("Enam", "Could you explain more about constructors?"));
        video2.AddComment(new Comment("Amenu", "Very informative."));
        video2.AddComment(new Comment("Sarah", "Helped me a lot, thanks!"));

        Video video3 = new Video("Advanced Inheritance", "John Doe", 600);
        video3.AddComment(new Comment("Nancy", "Very informative!"));
        video3.AddComment(new Comment("Almira", "I learned a lot, thanks!"));
        video3.AddComment(new Comment("Afeke", "Great examples."));
        video3.AddComment(new Comment("Godsway", "Well explained."));

        Video video4 = new Video("Polymorphism Explained", "Gideon Agbavor", 720);
        video4.AddComment(new Comment("Gideon", "Great examples!"));
        video4.AddComment(new Comment("Christabel", "Could you do more videos on this topic?"));
        video4.AddComment(new Comment("Benedict", "Very helpful."));
        video4.AddComment(new Comment("Fafali", "Excellent explanation."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Display video information
        foreach (var video in videos)
        {
            Console.WriteLine(video.GetVideoDetails());
            Console.WriteLine("Comments:");
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}
