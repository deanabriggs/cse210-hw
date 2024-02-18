using System.Security.Cryptography;

public class Weekly : Chores
{
    private int _day;

    Weekly(string name, string desc, int time, int age, int day) : base(name, desc, time, age)
    {
        _day = day;
    }
    Weekly(string name, string desc, int time, int age, int day, bool everyone, int people) : base(name, desc, time, age, everyone, people)
    {
        _day = day;
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
        List<int> dayList = new List<int>();
        dayList.Add(_day);
        return dayList;
    }

}