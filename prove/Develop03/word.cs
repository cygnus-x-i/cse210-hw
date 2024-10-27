class Word
{
    // Attributes
    string _word;
    bool _hidden = false;

    // Behaviors
    public string GetDisplayWord()
    {
        if (_hidden)
        {
            return new string('_', _word.Length); // Return underscores for hidden words
        }
        else
        {
            return _word; // Return the original word if not hidden
        }
    }

    // Getters
    public string GetWord()
    {
        return _word;
    }
    public bool GetHidden()
    {
        return _hidden;
    }

    // Setters
    public void SetWord(string word)
    {
        _word = word;
    }
    public void SetHidden(bool boolean)
    {
        _hidden = boolean;
    }
}