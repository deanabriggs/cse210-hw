public abstract class Goal
{
    // Variables / Atrributes
    protected string _shortName;
    protected string _description;
    protected int _points;           // is value the task is worth when completed

    // Constructors
    protected Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Functions / Methods
    public string getName()
    {
        return _shortName;
    }
    public abstract int RecordEvent();

    public abstract bool IsComplete();                      // DONE

    public virtual string GetDetailsString()                // DONE, overriden in Checklist Class
    {
        string status;
        if (IsComplete() == true)
            status = "X";
        else
            status = " ";
        return $"[{status}] {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();       // DONE
}