using System.ComponentModel;
using System.Security.Cryptography;

public class Daily : Chore
{
    private bool _am;

    public Daily() : base()
    {
        Console.Write("\nDoes this chore have to be done in the morning? (y/n): ");
        if (Console.ReadLine().ToLower() == "y") _am = true;
        else _am = false;
    }

    public Daily(string name, string desc, int time, int age, bool everyone, int people, bool am) : base(name, desc, time, age, everyone, people)
    {
        _am = am;
    }

    public override void EditChore()                        // DONE
    {
        base.EditChore();
        Console.Write("\nDoes this chore have to be done in the morning? (y/n): ");
        if (Console.ReadLine().ToLower() == "y") _am = true;
        else _am = false;
    }

    public override void DisplayChoreDetails()              // DONE
    {
        string morning;
        if (_am == true) morning = " | in the morning";
        else morning = "";

        base.DisplayChoreDetails();
        Console.Write(morning);
    }

    public override string StringRepresentation()           // DONE
    {
        return $"Daily{base.StringRepresentation()}|{_am}";
    }
}