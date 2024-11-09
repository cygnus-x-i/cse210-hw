class Breathing : Activity
{
    // Attributes 
    string _description = "Welcome to the Breathing Activity.\n\nThis activity will help you relax by walking you through breathing in and out slowly.  Clear your mind and focus on your breathing.\n\nHow many seconds do you want this session to be?  ";
    // Behaviors
    public int BreathingActivity()
    {
        Console.WriteLine("Breathe in...");
        Loading(3);
        Console.WriteLine("Hold...");
        Loading(3);
        Console.WriteLine("Breathe out...");
        Loading(4);
        return 0;
    }

    public string getDescription()
    {
        return _description;
    }

    public string GenerateEndMessage()
    {
        return $"Well done!\n\nYou have completed another {_actTime} seconds of the Breathing Activity.";
    }
}