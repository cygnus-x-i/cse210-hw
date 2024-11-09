class Reflection : Activity
{
    // Attributes
    List<string> _prompts = new() {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};

    List<string> _subPrompts = new() {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

    string _description = "Welcome to the Reflection Activity.\n\nThis activity will help you reflect on times in your life when you have shown strength and resilience.  This will help you recognize the power you have and how you can use it in other aspects of your life.\n\nHow many seconds long would you like this session to be?  ";

    // Behaviors
    public string GetPrompt()
    {
        Random random = new();
        int i = random.Next(_prompts.Count());
        string prompt = _prompts[i];
        return prompt;
    }

    public int ReflectionActivity()
    {
        string prompt = GetPrompt();
        Console.Write($"\n--- {prompt}--- \n");
        Loading(2);

        foreach (string subPrompt in _subPrompts)
        {
            Console.Write(subPrompt);
            Loading(2);
            Console.Write("     ");
            Console.ReadLine();
        }

        return 0;
    }

    public string getDescription()
    {
        return _description;
    }

    public string GenerateEndMessage()
    {
        return $"Well done!\n\nYou have completed another {_actTime} seconds of the Reflection Activity.";
    }

}