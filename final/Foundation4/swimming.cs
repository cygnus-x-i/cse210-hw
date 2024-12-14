class Swimming : Activity
{
    private int Laps;
    private const float LapDistanceInMiles = 0.03107f; // 50 meters in miles

    public Swimming(string date, int durationInMinutes, int laps)
        : base(date, durationInMinutes)
    {
        Laps = laps;
    }

    public override float GetDistance()
    {
        return Laps * LapDistanceInMiles;
    }

    public override float GetSpeed()
    {
        return GetDistance() / (DurationInMinutes / 60.0f);
    }

    public override float GetPace()
    {
        return DurationInMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{Date} Swimming ({DurationInMinutes} min): Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace {GetPace():F1} min per mile";
    }
}