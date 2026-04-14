public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public string Name
    {
        get {return _shortName;}
        set {_shortName = value;}
    }

    public string Description
    {
        get {return _description;}
        set {_description = value;}
    }

    public int Points
    {
        get {return _points;}
        set { _points = value;}
    }

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    public string GetDetailString()
    {
        return $"Your goal is: {_shortName} ({_description})";   
    }
}
