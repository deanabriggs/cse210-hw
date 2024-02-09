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