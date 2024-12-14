class Running : Activity
{
    private float DistanceInMiles;

    public Running(string date, int durationInMinutes, float distanceInMiles)
        : base(date, durationInMinutes)
    {
        DistanceInMiles = distanceInMiles;
    }

    public override float GetDistance()
    {
        return DistanceInMiles;
    }

    public override float GetSpeed()
    {
        return DistanceInMiles / (DurationInMinutes / 60.0f);
    }

    public override float GetPace()
    {
        return DurationInMinutes / DistanceInMiles;
    }

    public override string GetSummary()
    {
        return $"{Date} Running ({DurationInMinutes} min): Distance {DistanceInMiles:F1} miles, Speed {GetSpeed():F1} mph, Pace {GetPace():F1} min per mile";
    }
}