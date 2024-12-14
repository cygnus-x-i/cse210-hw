class OutdoorGathering : Event
{
    public string Weather;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        Weather = weather;
    }

    public override string FullDetails()
    {
        return $"{StandardDetails()}\nType: Outdoor Gathering\nWeather: {Weather}";
    }

    public override string ShortDescription()
    {
        return $"Type: Outdoor Gathering\nTitle: {Title}\nDate: {Date}";
    }
}