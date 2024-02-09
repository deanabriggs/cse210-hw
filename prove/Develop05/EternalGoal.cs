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

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}