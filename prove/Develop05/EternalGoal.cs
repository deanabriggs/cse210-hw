public class EternalGoal : Goal
{
    // Variable / Attributes
    //none

    // Constructors
    EternalGoal(string name, string description, int points) : base(name, description, points)
    {}

    // Functions / Methods
    public override void RecordEvent()
    {}

    public override bool IsComplete()                   // DONE (should always return false)
    {
        return false;
    }

    public override string GetStringRepresentation()    // DONE, but check format
    {
        return $"Checklist Goal:|{_shortName}|{_description}|{_points}";
    }
}