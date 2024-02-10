public class EternalGoal : Goal
{
    // Variable / Attributes
    //none

    // Constructors
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {}

    // Functions / Methods
    public override int RecordEvent()                   // DONE, returns point value of event
    {
        return _points;
    }

    public override bool IsComplete()                   // DONE (should always return false)
    {
        return false;
    }

    public override string GetStringRepresentation()    // DONE, returns string to save to file
    {
        return $"EternalGoal:{_shortName}|{_description}|{_points}";
    }
}