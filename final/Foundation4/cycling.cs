class Cycling : Activity
{
    private float SpeedInMph;

    public Cycling(string date, int durationInMinutes, float speedInMph)
        : base(date, durationInMinutes)
    {
        SpeedInMph = speedInMph;
    }

    public override float GetDistance()
    {
        return SpeedInMph * (DurationInMinutes / 60.0f);
    }

    public override float GetSpeed()
    {
        return SpeedInMph;
    }

    public override float GetPace()
    {
        return 60.0f / SpeedInMph;
    }

    public override string GetSummary()
    {
        return $"{Date} Cycling ({DurationInMinutes} min): Distance {GetDistance():F1} miles, Speed {SpeedInMph:F1} mph, Pace {GetPace():F1} min per mile";
    }
}