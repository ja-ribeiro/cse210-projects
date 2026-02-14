public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int point)
    {
        _shortName = name;
        _description = description;
        _points = point;
    }

    public string GetName()
    {
        return _shortName;
    }

    public int GetPoints()
    {
        return _points;
    }

    public string GetDescription()
{
    return _description;
}

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}