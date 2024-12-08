class Video
{
    public string Title;
    public string Author;
    public int LengthInSeconds;
    public List<Comment> Comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }

    public string GetFormattedLength()
    {
        int minutes = LengthInSeconds / 60;
        int seconds = LengthInSeconds % 60;
        return $"{minutes:D2}:{seconds:D2}";
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {GetFormattedLength()}");
        Console.WriteLine($"Comments ({GetCommentCount()}):");
        foreach (var comment in Comments)
        {
            Console.WriteLine($"  {comment}");
        }
    }
}