class Lecture : Event
{
    public string Speaker;
    public int Capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string FullDetails()
    {
        return $"{StandardDetails()}\nType: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }

    public override string ShortDescription()
    {
        return $"Type: Lecture\nTitle: {Title}\nDate: {Date}";
    }
}
