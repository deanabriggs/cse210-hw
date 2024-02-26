using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class Entities
{
    private List<Person> _people;
    private List<Chore> _theChores;
    private List<Assignment> _assignments;

    public Entities() 
    {
        _people = new List<Person>();
        _theChores = new List<Chore>();
        _assignments = new List<Assignment>();
    }

    public void AddNewPerson()
    {
        Person newPerson = new Person();
        _people.Add(newPerson);
    }

    private void AddNewChore()
    {
        Console.Write(
@"How often will this chore need to be done? 
  1. Daily
  2. A few times weekly
  3. Once per week
Enter an option (1-3): ");
        string choice = Console.ReadLine();
        
        if (choice == "1") 
        {
            Daily newChore = new Daily();
            _theChores.Add(newChore);
        }
        else if (choice == "2") 
        {
            SomeDays newChore = new SomeDays();
            _theChores.Add(newChore);
        }
        else if (choice == "3") 
        {
            Weekly newChore = new Weekly();
            _theChores.Add(newChore);
        }
        else
        {
            Console.WriteLine("Choice was invalid.");
        }
    }

    public void AssignChores() 
    {
        int numPeople = _people.Count();
        int numChores = _theChores.Count();
        if (numPeople !> 0 || numChores !> 0)
        {
            Console.WriteLine("You must have at least 1 chore and 1 person to assign chores.");
        }
    }

    public int DisplayPeopleToSelect()
    {
        Console.WriteLine("Select a person:");

        int numPeople = _people.Count();
        int i = 0;
        foreach (Person person in _people)
        {
            i++;
            Console.WriteLine($"  {i}. {person.GetName}");
        }
        Console.Write($"Select a choice (1-{numPeople}): ");
        return int.Parse(Console.ReadLine())-1;
    }
    
    public int DisplayChoresToSelect()
    {
        int numChores = _theChores.Count();
        int i = 0;
        foreach (Chore chore in _theChores)
        {
            i++;
            Console.WriteLine($"  {i}. {chore.DisplayChoreDetails}");
        }
        Console.Write($"Select a choice (1-{numChores}): ");
        return int.Parse(Console.ReadLine())-1;
    }

    public int GetPersonAge(Person person)
    {
        DateOnly dob = person.GetDOB();
        DateOnly today = DateOnly.FromDateTime(DateTime.Today);  // Helped from ChatGPT
        
        int age = today.Year - dob.Year;

        if (dob.DayOfYear > today.DayOfYear)
        {
            age--;
        }
        return age;
    }

}