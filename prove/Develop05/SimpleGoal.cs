using System.ComponentModel;
using System.Runtime.CompilerServices;

public class SimpleGoal : Goal
{
    // Variables / Attributes
    private bool _isComplete;

    // Constructors
    public SimpleGoal(string name, string description, int points, bool complete = false) : base(name, description, points)
    {
        _isComplete = complete;
    }

    // Functions / Methods
    public override int RecordEvent()        // DONE, Sets the status to true, returns associated point value                  
    {
        _isComplete = true;
        return _points;
    }

    public override bool IsComplete()        // DONE, returns status
    {
        if (_isComplete == true)
            return true;
        else
            return false;
    }

    public override string GetStringRepresentation()    // DONE, returns string to save to file
    {
        return $"SimpleGoal:{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}