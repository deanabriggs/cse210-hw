class MathAssignment : Assignment
{
    // Variables
    private string _textbookSection;
    private string _problems;

    // Constructors
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base (studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return GetSummary() +"\n"+ "Section " + _textbookSection + " Problems " + _problems;
    }
}