class Journal
{
    // Attributes
    public List<string> _entries = new();
    
    // Behaviors
    public void addEntry(string response)
    {
        _entries.Add(response);
    }

    public void displayAll()
    {
        Console.WriteLine("~~~~~ ~~~~~ ~~~~~ ~~~~~ ~~~~~ ~~~~~ ~~~~~");
        foreach(string i in _entries)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("~~~~~ ~~~~~ ~~~~~ ~~~~~ ~~~~~ ~~~~~ ~~~~~");
    }

    void saveList()
    {
        
    }
}
