using System.Globalization;
using System.Security.Cryptography;

public class SomeDays : Chore
{
    private List<int> _days;

    public SomeDays() : base()
    {
        Console.Write("Will this be for week days only? (y/n): ");
        if (Console.ReadLine().ToLower() == "y")
            _days = DefineWeekDays();
        else
            _days = DefineSomeDays();
    }

    public SomeDays(string name, string desc, int time, int age, bool everyone, int people, List<int> days) : base(name, desc, time, age, everyone, people)
    {
        _days = days;
    }

    public override void EditChore()                    // DONE
    {
        base.EditChore();
        Console.Write("Change days this chore needs to be done? (y/n): ");
        if (Console.ReadLine().ToLower() == "y")
        {
            Console.Write("Will this be for week days only? (y/n): ");
            if (Console.ReadLine().ToLower() == "y")
                _days = DefineWeekDays();
            else
                _days = DefineSomeDays();
        }
    }

    public override void DisplayChoreDetails()          // DONE
    {
        base.DisplayChoreDetails();
        Console.Write($" | {GetDayListAsString(_days)}");        
    }

    public override string StringRepresentation()       // DONE
    {
        return $"SomeDays{base.StringRepresentation()}|{GetDayListAsString(_days)}";
    }

    private List<int> DefineWeekDays()                  // DONE
    {
        List<int> dayList = new List<int>() {1, 2, 3, 4, 5};
        return dayList;
    }

    private List<int> DefineSomeDays()                  // DONE
    {
        List<int> dayList = new List<int>();
        Console.WriteLine("Select the days for this chore: ");
        Console.Write("  Sunday    (y/n): ");
        if (Console.ReadLine().ToLower() == "y") dayList.Add(0);
        Console.Write("  Monday    (y/n): ");
        if (Console.ReadLine().ToLower() == "y") dayList.Add(1);
        Console.Write("  Tuesday   (y/n): ");
        if (Console.ReadLine().ToLower() == "y") dayList.Add(2);
        Console.Write("  Wednesday (y/n): ");
        if (Console.ReadLine().ToLower() == "y") dayList.Add(3);
        Console.Write("  Thursday  (y/n): ");
        if (Console.ReadLine().ToLower() == "y") dayList.Add(4);
        Console.Write("  Friday    (y/n): ");
        if (Console.ReadLine().ToLower() == "y") dayList.Add(5);
        Console.Write("  Saturday  (y/n): ");       
        if (Console.ReadLine().ToLower() == "y") dayList.Add(6);

        return dayList;
    }

}