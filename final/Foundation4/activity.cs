class Activity
{
    public string Date;
    public int DurationInMinutes;

    public Activity(string date, int durationInMinutes)
    {
        Date = date;
        DurationInMinutes = durationInMinutes;
    }

    public virtual float GetDistance()
    {
        return 0;
    }

    public virtual float GetSpeed()
    {
        return 0;
    }

    public virtual float GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{Date}: {GetType().Name} ({DurationInMinutes} min)";
    }
}