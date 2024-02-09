public class ChecklistGoal : Goal
{
    // Variable / Attributes
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Constructors
    ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    // Functions / Methods
    public override void RecordEvent()
    {}

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return "";
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}