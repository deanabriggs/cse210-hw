public class ChecklistGoal : Goal
{
    // Variable / Attributes
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Constructors
    public ChecklistGoal(string name, string description, int points, int target, int bonus, int completed = 0) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = completed;
    }

    // Functions / Methods
    public override int RecordEvent()          // DONE, adds to the number completed, determines if target has been reached, returns points for event
    {
        _amountCompleted += 1;
        if (_amountCompleted < _target)
        {
            return _points;
        }
        else
        {
            return _points + _bonus;
        }
    }

    public override bool IsComplete()          // DONE, returns status
    {
        if (_amountCompleted < _target)
            return false;
        else
            return true;
    }

    public override string GetDetailsString()  // DONE, returns printable string of Detail
    {
        string status;
        if (IsComplete() == true)
            status = "X";
        else
            status = " ";
        return $"[{status}] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()    // DONE, returns string to save to file
    {
        return $"ChecklistGoal:{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}