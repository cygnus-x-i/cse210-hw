class Reference
{
    // Attributes
    string _verse;
    string _book;
    int _chapter;
    int _startVerse;
    int _endVerse;

    // Behaviors
    public void SetVerses(string verse, string book, int chapter, int startVerse, int endVerse)
    {
        _verse = verse;
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public void SetVerse(string verse)
    {
        _verse = verse;
    }

    public string GetReference()
    {
        if(_startVerse != _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
    }

    public string GetVerse()
    {
        return _verse;
    }

    public List<string> SplitWords()
    {
        List<string> words = new();
        foreach(string i in _verse.Split(" "))
        {
            words.Add(i);
        }
        return words;
    }

    public string ModifiedVerse(List<string> list)
    {
        string final = "";
        foreach(string i in list)
        {
            final += $"{i} ";
        }
        return final;
    }
}