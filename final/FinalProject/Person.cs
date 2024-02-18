public class Person
{
    private string _name;
    private DateOnly _dob;
    private List<Availability> _available;

    public Person(string name, DateOnly DOB)
    {
        _name = name;
        _dob = DOB;
    }
    public Person(string name, DateOnly DOB, List<Availability> available)
    {
        _name = name;
        _dob = DOB;
        _available = available;
    }

    public List<Availability> GetAvailability(DateOnly start, DateOnly end)  // will need to edited to return correct info
    {
        return _available;
    }

    public void DisplayAvailability(string name)
    {
        if (name == _name)
            Console.WriteLine($"{_name} {_available}");
    }

    public string StringRepresentation()
    {
        return "";
    }

    public void DisplayName()
    {
        Console.WriteLine(_name);
    }

    public void DeletePerson(string name)
    {

    }

    public void EditPerson(string name)
    {

    }
    public void SavePerson()
    {

    }

    public void LoadPerson()
    {
        
    }

}