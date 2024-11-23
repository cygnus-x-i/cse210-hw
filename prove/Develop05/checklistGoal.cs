class Checklist : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoints;

    public void Initialize(string title, string description, int pointVal, int targetCount, int bonusPoints)
    {
        base.Initialize(title, description, pointVal);
        _timesCompleted = 0;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

    public void IncrementCompletion()
    {
        _timesCompleted++;
    }

    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }

    public int GetTargetCount()
    {
        return _targetCount;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        if (_timesCompleted >= _targetCount)
        {
            _done = true;
            return _pointVal + _bonusPoints;
        }
        return _pointVal;
    }

    public override string GetStatus()
    {
        return _done
            ? "[X] Completed!"
            : $"[ ] Completed {_timesCompleted}/{_targetCount}";
    }
}
