public class Assign
{
    private Person _assignPerson;
    private Chores _assignChore;
    private DateOnly _choreDate;
    private bool _hidden;

    public Assign(Chores chore, DateOnly date)
    {
        _assignChore = chore;
        _choreDate = date;
    }

    public Assign(Chores chore, DateOnly date, Person person)
    {
        _assignChore = chore;
        _choreDate = date;
        _assignPerson = person;
    }

    public List<DateOnly> ApplicableDates(DateOnly start, DateOnly end)
    {
        List<DateOnly> dateList = new List<DateOnly>();
        return dateList;
    }

    public void LoadChoresForPeriod(List<DateOnly> dates, List<Person> people, List<Chores> chores)
    {

    }

    public void DisplayPersonalList(string name)
    {

    }

    public void DeleteChore()
    {

    }
    public void DeleteAssignment()
    {

    }

    public void AssignChores()
    {

    }

    public void DisplayCurrentAvailability()
    {

    }

    public void DisplayCurrentUnassignedChores()
    {

    }

    public void DisplayChoreChart()
    {

    }

    public string StringRepresentation()
    {
        return "";
    }

    public void LoadAssigned(string filename)
    {

    }

    public void SaveAssigned()
    {

    }

    public void DisplayForDate(DateOnly date)
    {
        
    }


}