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
        _amountCompleted = 0;
    }

    // Functions / Methods
    public override void RecordEvent()
    {

    }

    public override bool IsComplete()           // DONE
    {
        if (_amountCompleted < _target)
            return false;
        else
            return true;
    }

    public override string GetDetailsString()  // DONE, but check format
    {
        string status;
        if (IsComplete() == true)
            status = "X";
        else
            status = " ";

        return $"[{status}] {_shortName}: {_description} - Progress: {_amountCompleted}\\{_target}";
    }

    public override string GetStringRepresentation()    // DONE, but check format
    {
        return $"Checklist Goal:|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}