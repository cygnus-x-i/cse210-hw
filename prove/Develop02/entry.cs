class Entry
{
    // Attributes
    List<string> _promptList = new() 
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",   
    };
    

    // Behaviors
    public string generatePrompt()
    {
        Random random = new();
        int index = random.Next(_promptList.Count);
        string chosenPrompt = _promptList[index];
        return chosenPrompt;
    }

    public string displayPrompt(string chosenPrompt)
    {
        Console.Write($"{generatePrompt()}\n>> ");
        string userResponse = Console.ReadLine();
        return userResponse;
    }

    public string saveResponse(string chosenPrompt, string response)
    {
        DateTime _date = DateTime.Today;
        string formattedDate = _date.ToString("MM-dd-yyyy");
        string responseToSave = $"{formattedDate}  |  {chosenPrompt}\n>> {response}";
        return responseToSave;
    }

}