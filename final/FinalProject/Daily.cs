using System.Security.Cryptography;

public class Daily : Chores
{
    private bool _am;

    public Daily() : base()
    {
        Console.Write("Does this chore have to be done in the morning? (y/n): ");
        if (Console.ReadLine().ToLower() == "y")
        {_am = true;}
        else {_am = false;}
    }
    public Daily(string name, string desc, int time, int age, bool everyone=false, int people=1) : base(name, desc, time, age, everyone, people)
    {
        _am = false;
    }

    public override string ChoreDetails()
    {
        return "";
    }

    public override string StringRepresentation()
    {
        return $"Daily:{_choreName}|{_description}|{_time}|{_minAge}|{_everyone}|{_numOfPeople}|{_am}";
    }
}