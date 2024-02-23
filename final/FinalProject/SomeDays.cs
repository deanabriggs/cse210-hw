using System.Security.Cryptography;

public class SomeDays : Chores
{
    private List<int> _days;

    public SomeDays() : base()
    {
        Console.Write("Will this be for week days only? (y/n): ");
        if(Console.ReadLine().ToLower() == "y")
            DefineWeekDays();
        else
            DefineSomeDays();
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
        return $"SomeDays{base.StringRepresentation()}|{_days}";
    }

    static List<int> DefineWeekDays()
    {
        List<int> dayList = new List<int>() {1, 2, 3, 4, 5};
        return dayList;
    }

    static List<int> DefineSomeDays()
    {
        List<int> dayList = new List<int>();
        Console.WriteLine("Select the days for this chore: ");
        Console.Write("  Monday    (y/n): ");
        string m = Console.ReadLine().ToLower();
        Console.Write("  Tuesday   (y/n): ");
        string t = Console.ReadLine().ToLower();
        Console.Write("  Wednesday (y/n): ");
        string w = Console.ReadLine().ToLower();
        Console.Write("  Thursday  (y/n): ");
        string th = Console.ReadLine().ToLower();
        Console.Write("  Friday    (y/n): ");
        string f = Console.ReadLine().ToLower();
        Console.Write("  Saturday  (y/n): ");
        string sat = Console.ReadLine().ToLower();
        Console.Write("  Sunday    (y/n): ");
        string sun = Console.ReadLine().ToLower();

        if (m == "y") dayList.Add(1);
        if (t == "y") dayList.Add(2);
        if (w == "y") dayList.Add(3);
        if (th == "y") dayList.Add(4);
        if (f == "y") dayList.Add(5);
        if (sat == "y") dayList.Add(6);
        if (sun == "y") dayList.Add(0);

        return dayList;
    }

    public override void SaveChores()
    {}
    public override void LoadChores()
    {}
}