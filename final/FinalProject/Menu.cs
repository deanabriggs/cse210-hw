using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Xml.Serialization;

public class Menus
{
    private List<DateOnly> _selectedDates;
    private List<ChoreByDate> _choreByDate;
    private List<Entities> _entities;
    private List<string> _entityNames;
    private List<string> _actions;
    private int _entityNamesLen;
    private int _actionsLen;
    private string _currentEntity;
    private string _currentAction;

   
    public Menus()
    {
        _selectedDates = default;
        _choreByDate = new List<ChoreByDate>();
        _entities = new List<Entities>();
        _entityNames = new List<string> {"People", "Chores", "Assignments", "Exit"};    // LAST list item will exit program
        _actions = new List<string> {"Add", "View", "Edit", "Quit"};                    // LAST list item will quit action
        _entityNamesLen = _entityNames.Count();
        _actionsLen = _actions.Count();
        _currentEntity = "";
        _currentAction = "";
    }

    public List<DateOnly> GetDatesForRange ()
    {
        Console.WriteLine("Enter the DATE RANGE you want to manage");
        Console.Write("Enter Start Date: ");
        DateOnly startDate = DateOnly.Parse(Console.ReadLine());
        Console.Write("Enter End Date: ");
        DateOnly endDate = DateOnly.Parse(Console.ReadLine());
        
        List<DateOnly> theseDates = new List<DateOnly>();
        while (startDate < endDate)
        {
            startDate = startDate.AddDays(1);
            theseDates.Add(startDate);
        }
        Console.Clear();
        return theseDates;
    }

    public void RunProgram()
    {
        new Menus();
        new Entities();
        DisplayHeader();
        _selectedDates = GetDatesForRange();
        int exitEntity = _entityNamesLen;
        int quitAction = _actionsLen;
        while (_currentEntity == "" || _currentEntity != _entityNames[exitEntity])
        {
            DisplayEntityChoiceMenu();
            bool continueEntity;
            do 
            { 
                Console.Clear();
                DisplayHeader();
                DisplayActionSubMenu(_currentEntity);
                
                bool continueAction;
                do
                { 
                    continueAction = DisplayActionContinueMenu(_currentEntity, _currentAction);
                } while (continueAction == true);
                _currentAction = _actions[quitAction];
                continueEntity = DisplayEntityContinueMenu(_currentEntity);

            } while (continueEntity == true);
            _currentEntity = _entityNames[exitEntity];
        }
    }

    public void DisplayHeader()        // Done
    {
        Console.WriteLine("                    CHORE ASSIGNMENT PROGRAM");
        Console.WriteLine("                   Manager Your Family Chores\n");
    }
    
    public int DisplayEntityChoiceMenu()
    {
        Console.WriteLine("Choose an entity:");
        int i = 0;
        foreach (string entity in _entityNames)
        {
            i++;
            Console.WriteLine($"  {i}. {entity}");
        }
        Console.Write($"Select a choice (1-{_entityNamesLen}): ");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine(choice);                                  // TESTING
        SetCurrentEntity(choice);

        return choice;
    }

    public int DisplayActionSubMenu(string entityName)
    {
        Console.WriteLine($"Choose an action for {entityName.ToUpper()}:");
        int i = 0;
        foreach (string action in _actions)
        {
            i++;
            Console.WriteLine($"  {i}. {_actions[i-1]}");
        }
        Console.Write($"Select a choice (1-{_actionsLen}): ");
        int choice = int.Parse(Console.ReadLine());
        
        SetCurrentAction(choice);

        return choice;
    }

    public bool DisplayActionContinueMenu(string entity, string action)
    {
        Console.Write($"\nDo you want to continue to {action.ToUpper()} {entity} (y/n)? ");
        string choice = Console.ReadLine().ToLower();
        Console.Clear();
        if (choice == "y")
        {
            return true;
        }
        return false;
    }

        public bool DisplayEntityContinueMenu(string entity)
    {
        Console.Write($"\nDo you want to continue to working with {entity} (y/n)? ");
        string choice = Console.ReadLine().ToLower();
        Console.Clear();
        if (choice == "y")
        {
            return true;
        }
        return false;
    }

     public void SetCurrentEntity(int entityChoice)
    {
        if (entityChoice <= _entityNamesLen)
        {
            _currentEntity = _entityNames[entityChoice-1];
        }
        _currentEntity = "Invalid";        
    }

      public void SetCurrentAction (int actionChoice)
    {
        if (actionChoice <= _actionsLen)
        {
            _currentAction = _actions[actionChoice-1];
        }
        _currentAction = "Invalid"; 
    }

    public string Get_currentAction()
    {
        return _currentAction;
    }

}