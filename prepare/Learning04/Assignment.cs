using System;

public class Assignment
{
    // variables
    private string _studentName;
    private string _topic;

    // constructors
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // functions
    public string GetSummary()
    {
        return _studentName +" - "+ _topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }
}