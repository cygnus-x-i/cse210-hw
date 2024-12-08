class Program
{
    static void Main(string[] args)
    {
        // Create some random videos
        var video1 = new Video("C# Tutorial", "John Doe", 600);
        var video2 = new Video("Learn .NET", "Jane Smith", 450);

        // Add comments to videos
        video1.AddComment(new Comment("Alex", "Great tutorial, thanks!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "I have a question about..."));

        video2.AddComment(new Comment("Diana", ".NET is so powerful!"));
        video2.AddComment(new Comment("Evan", "Good explanation."));

        // Create a list of videos
        var videos = new List<Video> { video1, video2 };

        // Display info for each video
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine(); // Blank line between videos
        }
    }
}
