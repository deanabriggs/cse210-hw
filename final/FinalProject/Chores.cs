using System.ComponentModel;
using System.Runtime;

public abstract class Chores
{
    private string _choreName;
    private string _description;
    private int _time;
    private int _minAge;
    private bool _everyone;
    private int _numOfPeople;

    public Chores(string name, string desc, int time, int age, bool everyone=false, int people=1)
    {
        _choreName = name;
        _description = desc;
        _time = time;
        _minAge = age;
        _everyone = everyone;
        _numOfPeople = people;
    }

    public abstract string ChoreDetails();
    public abstract string StringRepresentation();
    public abstract List<int> DefineDays();
    public string GetName()
    {
        return _choreName;
    }
    public void SaveChores()
    {}

    public void LoadChores()
    {}

    public void EditChore()
    {}

    public void DeleteChore()
    {}

}