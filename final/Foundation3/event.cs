class Event
{
    public string Title;
    public string Description;
    public string Date;
    public string Time;
    public Address Address;

    public Event(string title, string description, string date, string time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    public string StandardDetails()
    {
        return $"Event: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nAddress:\n{Address.FullAddress()}";
    }

    public virtual string FullDetails()
    {
        return StandardDetails();
    }

    public virtual string ShortDescription()
    {
        return $"Type: General Event\nTitle: {Title}\nDate: {Date}";
    }
}