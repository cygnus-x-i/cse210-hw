class Listing : Activity
{
    // Attributes
    List<string> _prompts = new() {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};

    string _description = "Welcome to the Listing Activity.\n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n\nHow many seconds would you like this session to be?  ";
    // Behaviors
    public string GetPrompt()
    {
        Random random = new();
        int i = random.Next(_prompts.Count());
        string prompt = _prompts[i];
        return prompt;
    }

    public int ListingAct()
    {
        Console.WriteLine($"\n--- {GetPrompt()} ---\n");
        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_actTime);
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter a response: ");
            string response = Console.ReadLine();
            responses.Add(response);
        }

        Console.WriteLine($"You listed {responses.Count} items!");
        return 0;
    }
    
    public string getDescription()
    {
        return _description;
    }

    public string GenerateEndMessage()
    {
        return $"Well done!\n\nYou have completed another {_actTime} seconds of the Listing Activity.";
    }

}