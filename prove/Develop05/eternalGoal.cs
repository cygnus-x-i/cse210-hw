class Eternal : Goal
{
    public override int RecordEvent()
    {
        return _pointVal; // Does not mark as done
    }

    public override string GetStatus()
    {
        return "[∞]";
    }
}
