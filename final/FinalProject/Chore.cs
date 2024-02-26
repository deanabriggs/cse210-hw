using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Runtime;

public abstract class Chore
{
    private string _choreName;
    private string _description;
    private int _time;
    private int _minAge;
    private bool _everyone;
    private int _numOfPeople;

    public Chore()
    {
        Console.Clear();
        Console.Write("NAME of chore: ");
        _choreName = Console.ReadLine();

        Console.Write("DESCRIPTION: ");
        _description = Console.ReadLine();

        Console.Write("TIME to complete (in minutes): ");
        _time = int.Parse(Console.ReadLine());

        Console.Write("AGE minimum to do: ");
        _minAge = int.Parse(Console.ReadLine());

        Console.Write("EVERYONE individually completes? (y/n): ");
        if (Console.ReadLine().ToLower() == "y")
            {
                _everyone = true;
                _numOfPeople = 1;
            }
        else 
            {
                _everyone = false;
                Console.Write("MORE THAN 1 person to do? (y/n): ");
                    if (Console.ReadLine().ToLower() == "n")
                        {
                            _numOfPeople = 1;
                        }
                    else 
                        {
                            Console.Write("HOW MANY working together? ");
                            _numOfPeople = int.Parse(Console.ReadLine());
                        }
            }
    }
    
    public Chore(string name, string desc, int time, int age, bool everyone=false, int people=1)
    {
        _choreName = name;
        _description = desc;
        _time = time;
        _minAge = age;
        _everyone = everyone;
        _numOfPeople = people;
    }
    
    public virtual (string name, string desc, int time, int age, bool everyone, int people) GetChoreDetails()
    {
        return (_choreName, _description, _time, _minAge, _everyone, _numOfPeople);
    }

    public void DisplayChoreName()                  // DONE
    {
        Console.Write($"{_choreName} - {_time} min");
    }
    
    public virtual void DisplayChoreDetails()       // DONE
    {
        string mark = "";
        if (_everyone == true) mark = "*";
        
        string pronoun = "person";
        if (_numOfPeople > 1) pronoun = "people";

        Console.Write($"{mark}{_choreName}: {_description} | {_time} min | by {_numOfPeople} {pronoun} | {_minAge} years old");
    }

    public virtual void EditChore()                 // DONE
    {
        Console.Write($"Change name for '{_choreName}' (y/n)? ");
        if (Console.ReadLine() == "y") {
            Console.Write("New name: ");
            _choreName = Console.ReadLine();
        }

        Console.Write($"Change description '{_description}' (y/n)? ");
        if (Console.ReadLine() == "y") {
            Console.Write("New description: ");
            _description = Console.ReadLine();
        }

        Console.Write($"Change time from '{_time} minutes' (y/n)? ");
        if (Console.ReadLine() == "y") {
            Console.Write("New time: ");
            _time = int.Parse(Console.ReadLine());
        }        

        Console.Write($"Change minimum age '{_minAge} years old' (y/n)? ");
        if (Console.ReadLine() == "y") {
            Console.Write("New min Age: ");
            _minAge = int.Parse(Console.ReadLine());
        }

        Console.Write("Should EVERYONE individually do this chore (y/n)? ");
        if (Console.ReadLine().ToLower() == "y")
            {
                _everyone = true;
                _numOfPeople = 1;
            }
        else 
            {
                _everyone = false;
                Console.Write("Should this be worked by MORE THAN 1 person at a time (y/n)? ");
                    if (Console.ReadLine().ToLower() == "n")
                        {
                            _numOfPeople = 1;
                        }
                    else 
                        {
                            Console.Write("How MANY people should work on this together? ");
                            _numOfPeople = int.Parse(Console.ReadLine());
                        }
            }  

    }

    public virtual string StringRepresentation()    // DONE
    {
        return $"Chores:{_choreName}|{_description}|{_time}|{_minAge}|{_everyone}|{_numOfPeople}";
    }

    public string GetDayListAsString(List<int> days)
    {
        List<string> daysOfWeek = days.Select(day => GetDayNameAbb(day)).ToList();
        string result = string.Join(", ", daysOfWeek);
        return result;
    }

    public string GetDayNameAbb(int number)
    {
        DayOfWeek dayOfWeek = (DayOfWeek)(number % 7);
        return dayOfWeek.ToString("ddd");
    }
}