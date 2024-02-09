public abstract class Goal
{
    // Variables / Atrributes
    protected string _shortName;
    protected string _description;
    protected int _points;

    // Constructors
    protected Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Functions / Methods
    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $"[ ] {_shortName}: {_description}";
    }

    public abstract string GetStringRepresentation();
}