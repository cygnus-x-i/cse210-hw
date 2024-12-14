class Program
{
    static void Main(string[] args)
    {
        // Create activities
        Running running = new Running("03 Nov 2022", 30, 3.0f); // 3 miles in 30 minutes
        Cycling cycling = new Cycling("04 Nov 2022", 45, 15.0f); // 15 mph for 45 minutes
        Swimming swimming = new Swimming("05 Nov 2022", 20, 40); // 40 laps in 20 minutes

        // Add activities to a list
        Activity[] activities = { running, cycling, swimming };

        // Display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
