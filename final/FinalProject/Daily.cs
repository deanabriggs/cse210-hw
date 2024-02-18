using System.Security.Cryptography;

public class Daily : Chores
{
    private bool _am;

    Daily(string name, string desc, int time, int age, bool am=false) : base(name, desc, time, age)
    {
        _am = am;
    }
    Daily(string name, string desc, int time, int age, bool am=false, bool everyone=false, int people=1) : base(name, desc, time, age, everyone, people)
    {
        _am = am;
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
        dayList.Add(0);
        dayList.Add(1);
        dayList.Add(2);
        dayList.Add(3);
        dayList.Add(4);
        dayList.Add(5);
        dayList.Add(6);
        return dayList;
    }

}