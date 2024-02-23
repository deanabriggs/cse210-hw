using System.Security.Cryptography;

public class Weekly : Chores
{
    private int _day;

    public Weekly() : base()
    {
        _day = MenuWeekdayValue();
    }
    public Weekly(string name, string desc, int time, int age, int day, bool everyone, int people) : base(name, desc, time, age, everyone, people)
    {
        _day = day;
    }

    public override string ChoreDetails()
    {
        return "";
    }

    public override string DisplayChores()
    {
        return base.DisplayChores() + $" | on {(DayOfWeek)_day}";
    }
public override string StringRepresentation()
    {
        return $"SomeDays{base.StringRepresentation()}|{_day}";
    }

    public int MenuWeekdayValue()
    {
Console.WriteLine(
@"What day should this be worked? 
  1. Monday
  2. Tuesday
  3. Wednesday
  4. Thursday
  5. Friday
  6. Saturday
  7. Sunday
Enter option (1-7): ");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 7) {_day = 0;}
        else {_day = choice;}

        return choice;
    }

    public override void SaveChores()
    {}
    public override void LoadChores()
    {}

}