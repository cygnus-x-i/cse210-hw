class Goal
{
    protected string _title;
    protected string _description;
    protected int _pointVal;
    protected bool _done;

    public void Initialize(string title, string description, int pointVal)
    {
        // Makes everything ready
        _title = title;
        _description = description;
        _pointVal = pointVal;
        _done = false;
    }

    public virtual int RecordEvent()
    {
        _done = true;
        return _pointVal;
    }

    public bool IsDone()
    {
        return _done;
    }

    public virtual string GetStatus()
    {
        // I learned this from my SystemVerilog Class :)
        return _done ? "[X]" : "[ ]";
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetPointValue(int points)
    {
        _pointVal = points;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _pointVal;
    }
}