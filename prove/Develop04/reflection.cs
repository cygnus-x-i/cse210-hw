class Reflection : Activity
{
    // Attributes
    string _description = "";
    List<string> _prompts = new();

    // Behaviors
    public string GetPrompt()
    {
        Random random = new();
        int i = random.Next(_prompts.Count());
        string prompt = _prompts[i];
        return prompt;
    }

    public void ReflectionActivity()
    {

    }

}