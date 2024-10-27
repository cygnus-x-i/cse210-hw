class Verse
{
    // Attributes
    private List<Word> _words = new();

    // Behaviors
    public void DisplayVerses(Reference reference)
    {
        string verse = "";
        foreach (Word word in _words)
        {
            verse += word.GetDisplayWord() + " "; // Display words (or underscores for hidden)
        }
        Console.WriteLine($"{reference.GetReference()}  {verse.TrimEnd()}"); // Display reference and verse
    }

    public void CreateList(List<string> words)
    {
        _words.Clear(); // Clear existing words
        foreach (string i in words)
        {
            Word word = new();
            word.SetWord(i);
            _words.Add(word); // Create a list of Word objects
        }
    }

    public int HideWord()
    {
        Random random = new();
        List<Word> hiddenCandidates = _words.Where(word => !word.GetHidden()).ToList(); // Get unhidden words

        if (hiddenCandidates.Count > 0)
        {
            Word selectedWord = hiddenCandidates[random.Next(hiddenCandidates.Count)];
            selectedWord.SetHidden(true); // Hide the selected word
            return 1; // Return 1 to indicate that a word was hidden
        }
        return 0; // Return 0 if no words were available to hide
    }

    public bool HasUnhiddenWords()
    {
        return _words.Any(word => !word.GetHidden()); // Check if any words are still unhidden
    }

    public void PrepareVerse(Reference reference)
    {
        List<string> words = reference.SplitWords();
        CreateList(words); // Populate the word list from reference
    }
}
