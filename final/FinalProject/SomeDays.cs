using System.Security.Cryptography;

public class SomeDays : Chores
{
    private List<int> _days;

    SomeDays(string name, string desc, int time, int age, List<int> days) : base(name, desc, time, age)
    {
        _days = days;
    }
    SomeDays(string name, string desc, int time, int age, List<int> days, bool everyone, int people) : base(name, desc, time, age, everyone, people)
    {
        _days = days;
    }

    public override string ChoreDetails()
    {
        return "";
    }

    public override string StringRepresentation()
    {
        return "";
    }

    public override List<int> DefineDays()
    {
        return _days;
    }

    public List<int> DefineWeekDays()
    {
        List<int> dayList = new List<int>() {1, 2, 3, 4, 5};
        return dayList;
    }
}