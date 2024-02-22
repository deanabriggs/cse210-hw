using System.ComponentModel;
using System.Formats.Asn1;
using System.Xml.Serialization;

public class Person
{
    private string _name;
    private DateOnly _dob;
    private List<Availability> _available;

    public Person()
    {
        Console.Write("Enter name of chore person: ");
        _name = Console.ReadLine();
        Console.Write("Enter their birthday? ");
        _dob = DateOnly.Parse(Console.ReadLine());
        _available = addPersonsAvailableList();
    }
    public Person(string name, DateOnly DOB)
    {
        _name = name;
        _dob = DOB;
        _available = addPersonsAvailableList();
    }
    public Person(string name, DateOnly DOB, List<Availability> available)
    {
        _name = name;
        _dob = DOB;
        _available = available;
    }

    static List<Availability> addPersonsAvailableList()     // DONE  - helps create a new object
    {
        Console.Write("About how much chore TIME is available each day (in minutes)? ");
        int minutes = int.Parse(Console.ReadLine());
        List<Availability> newAvailable = new List<Availability>();
        for (int i=0; i < 7; i++)
        {
            Availability day = new Availability(i, minutes);
            newAvailable.Add(day);
        }
        Console.WriteLine($"\nChore availability for has been set for {minutes} minutes each day.");
        return newAvailable;
    }

    public void DisplayAvailability()                       // DONE
    {
        Console.Clear();
        Console.WriteLine($"{_name} - {_dob}");
        int i = 0;
        foreach (Availability item in _available)
        {
            ++i;
            Console.WriteLine($" {i}. {item.GetAvailability()}");
        }
    }

    public string StringRepresentation()                            // DONE  - CHECK how availability is returned
    {
        return $"Person:{_name}|{_dob}|{_available}";
    }


    public string GetName()                                         // DONE
    {
        return _name;
    }
    
    public void DeletePerson()                                      // DONE
    {
        _name = null;
        _dob = default;
        _available = null;
    }

    public void EditPerson()                                        // DONE  - resets values based on new inputs
    {
        Console.Write($"Change name for '{_name}' (y/n)? ");
        if (Console.ReadLine() == "y") {
            Console.Write("Enter the new name: ");
            _name = Console.ReadLine();
        }
        
        Console.Write($"Change Date-Of-Birth from '{_dob}' (y/n)? ");
        if (Console.ReadLine() == "y") {
            Console.Write("Enter the new DOB: ");
            string enteredDOB = Console.ReadLine();
            _dob = DateOnly.Parse(enteredDOB);
        }

        DisplayAvailability();
        Console.Write("Change availability (y/n)? ");
        string choice = Console.ReadLine();

        while (choice != "n") {
            DisplayAvailability();
            ChangeTimeMenu();
            Console.Write("Do you want to change another day?");
            choice = Console.ReadLine();
        }
    }

    public void editPersonsAvailability(int onDay, int newTime)    // DONE 
    {
        foreach (Availability item in _available)
        {
            if (item.GetDay() == onDay)
            {
                item.SetTime(newTime);
            }
        }
    }

    public void ChangeTimeMenu()                                    // DONE
    {
        Console.Write("Which day do you want to change (1-7): ");
        int day = int.Parse(Console.ReadLine())-1;
        
        Console.Write("How much chore TIME is available that day (in minutes)? ");
        int newTime = int.Parse(Console.ReadLine());

        editPersonsAvailability(day, newTime);
    }
      
    public void SavePerson()
    {

    }

    public void LoadPerson()
    {
        
    }

    // public void GetDateAvailability(DateOnly start, DateOnly end){}  // will need to edited to return correct info
}
