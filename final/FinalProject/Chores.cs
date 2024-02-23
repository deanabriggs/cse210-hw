using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Runtime;

public abstract class Chores
{
    private string _choreName;
    private string _description;
    private int _time;
    private int _minAge;
    private bool _everyone;
    private int _numOfPeople;

    protected Chores()
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
    public Chores(string name, string desc, int time, int age, bool everyone=false, int people=1)
    {
        Console.Write("Enter chore name: ");
        _choreName = name;
        _description = desc;
        _time = time;
        _minAge = age;
        _everyone = everyone;
        _numOfPeople = people;
    }

    public abstract string ChoreDetails();

    public string GetName()                         // DONE
    {
        return _choreName;
    }

    public virtual string DisplayChores()           // DONE
    {
        string mark = "";
        if (_everyone == true) {mark = "*";}
        return $"{mark}{_choreName}: {_description} | {_time} min | by {_numOfPeople} - {_minAge} years old";
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

    public virtual string StringRepresentation()
    {
        return $"Chores:{_choreName}|{_description}|{_time}|{_minAge}|{_everyone}|{_numOfPeople}";
    }

    public virtual void DisplayChore()
    {
        Console.WriteLine($"{_choreName} - {_time} min");
    }

    public abstract void SaveChores();
    public abstract void LoadChores();

}