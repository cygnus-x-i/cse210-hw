class Reception : Event
{
    public string RSVPEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        RSVPEmail = rsvpEmail;
    }

    public override string FullDetails()
    {
        return $"{StandardDetails()}\nType: Reception\nRSVP Email: {RSVPEmail}";
    }

    public override string ShortDescription()
    {
        return $"Type: Reception\nTitle: {Title}\nDate: {Date}";
    }
}