using System.Security.Cryptography;

public class Weekly : Chore
{
    private int _day;

    public Weekly() : base()
    {
        _day = MenuWeekdayValue();
    }

    public Weekly(string name, string desc, int time, int age, bool everyone, int people, int day) : base(name, desc, time, age, everyone, people)
    {
        _day = day;
    }

    public override void EditChore()                            // DONE
    {
        base.EditChore();
        _day = MenuWeekdayValue();
    }

    public override void DisplayChoreDetails()                  // DONE
    {
        base.DisplayChoreDetails(); 
        Console.WriteLine($" | on {GetDayNameAbb(_day)}");
    }
    
    public override string StringRepresentation()               // DONE
    {
        return $"Weekly{base.StringRepresentation()}|{_day}";
    }

    private int MenuWeekdayValue()                              // DONE
    {
        Console.WriteLine(
@"What day should this be worked? 
  1. Sunday
  2. Monday
  3. Tuesday
  4. Wednesday
  5. Thursday
  6. Friday
  7. Saturday
Enter option (1-7): ");
        int choice = int.Parse(Console.ReadLine())-1;

        return choice;
    }
}