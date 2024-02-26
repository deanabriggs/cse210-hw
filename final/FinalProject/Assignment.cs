public class Assignment
{
    private string _assignPerson;
    private string _assignChore;
    private DateOnly _choreDate;


    public Assignment(DateOnly choreDate, string chore)
    {
        _choreDate = choreDate;
        _assignChore = chore;
        _assignPerson= "";
    }

    public Assignment(DateOnly choreDate, string chore, string person)
    {
        _assignPerson = person;
        _assignChore = chore;
        _choreDate = choreDate;
    }

    public void EditAssignment(DateOnly choreDate, string chore, string person)
    {
        _assignPerson = person;
        _assignChore = chore;
        _choreDate = choreDate;
    }

    public string StringRepresentation()
    {
        return $"Assignment:{_assignPerson}|{_assignChore}|{_choreDate}";
    }

    public (string, string, DateOnly) GetAssignment()
    {
        return (_assignPerson, _assignChore, _choreDate);
    }

    public void DisplayAssignment()
    {
        Console.WriteLine($"{_choreDate} - {_assignPerson} - {_assignChore}");
    }
}