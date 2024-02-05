class WritingAssignment : Assignment
{
    // Variables
    private string _title;

    // Constructors
    public WritingAssignment(string studentName, string topic, string title) : base (studentName, topic)
    {
        _title = title;
    }

    // Fuctions
    public string GetWritingInformation()
    {
        return $"{GetSummary()} \n{_title} by {GetStudentName()}";
    }
}