class Simple : Goal
{
    public override int RecordEvent()
    {
        _done = true;
        return _pointVal;
    }
}
