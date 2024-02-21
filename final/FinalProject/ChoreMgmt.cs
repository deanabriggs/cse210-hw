public class ChoreMgmt
{
    private List<Person> _people;
    private List<Chores> _theChores;
    private List<Assign> _assignments;

    public ChoreMgmt() 
    {
        _people = new List<Person>();
        _theChores = new List<Chores>();
        _assignments = new List<Assign>();
    }

    public List<DateOnly> DefineDays(DateOnly start, DateOnly end)
    {
        List<DateOnly> dateList = new List<DateOnly>();
        return dateList;
    }

    public void MainMenu()
    {
        string userInput = "";
        while (userInput != "9")
        {
            DisplayMainMenu();
            userInput = Console.ReadLine();

            if (userInput == "1")               // DONE    Add/Edit/View a person
            {
                Console.Write("\nWhich would you like to do?\n  1. Add \n  2. View \n  3. Edit \nSelect a choice from the menu: ");
                string userChoice = Console.ReadLine();
                    if (userChoice == "1")              // Add persosn
                    {
                        Console.Clear();
                        _people.Add(new Person());
                    }
                    else if (userChoice == "2")         // View person
                    {
                        Console.Clear();
                        Console.WriteLine("These are the available people to view: ");
                        foreach(Person item in _people)
                        {
                            Console.WriteLine($"  {item.GetName()}");
                        }
                        Console.Write("\nWho whould you like to VIEW: ");
                        string nameEntered = Console.ReadLine();
                        Console.Clear();
                        
                        foreach(Person item in _people)
                        {
                            if (nameEntered.ToLower() == item.GetName().ToLower())
                            {
                                item.DisplayAvailability();
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (userChoice == "3")         // Edit person
                    {
                        Console.Clear();
                        Console.WriteLine("These are the available people to edit: ");
                        foreach(Person item in _people)
                        {
                            Console.WriteLine($"  {item.GetName()}");
                        }
                        Console.Write("\nWho whould you like to EDIT: ");
                        string nameEntered = Console.ReadLine();
                        Console.Clear();
                        
                        foreach(Person item in _people)
                        {
                            if (nameEntered.ToLower() == item.GetName().ToLower())
                            {
                                string change = "y";
                                while (change == "y")
                                {
                                    item.DisplayAvailability();
                                    Console.WriteLine();
                                    item.ChangeTimeMenu();
                                    Console.Write("\nWould you like to make another change? (y/n) ");
                                    change = Console.ReadLine();
                                }
                            }
                        }
                    }
            }
        }
    }
    public void DisplayMainMenu()
    {
        Console.Write(
@"
Menu Options:
  1. Add/View/Edit a person
  2. Add/View/Edit a chore
  3. Assign Chores
  4. Save your chore list
  5. Load an existing chore list
  6. View Chore List
  7. View Unassigned Chores
  8. View Time Availability
  9. Exit the program
Select a choice from the menu: ");
    }

    public void DisplayPeople()
    {

    }

    public void DisplayChores()
    {

    }

    public void DisplayAssign()
    {

    }

    public void SaveFile()
    {

    }

    public void LoadFile()
    {

    }

    public void DeleteChore()
    {

    }

    public void EditChore()
    {

    }

    public void AddChore()
    {

    }

    public void ClearAssignments()
    {

    }
}
