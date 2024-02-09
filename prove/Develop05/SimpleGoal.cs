using System.ComponentModel;
using System.Runtime.CompilerServices;

public class SimpleGoal : Goal
{
    // Variables / Attributes
    private bool _isComplete;

    // Constructors
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    // Functions / Methods
    public override void RecordEvent()
    {

    }

    public override bool IsComplete()                   // DONE
    {
        if (_isComplete == true)
            return true;
        else
            return false;
    }

    public override string GetStringRepresentation()    // DONE, but check format
    {
        return $"Checklist Goal:|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}