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

    public void RunProgram()
    {
        string entityChoice = DisplayMainMenu();
        do
        {
            (string entity, string action) = DisplaySecondMenu(entityChoice);
            do
            {
                if (entity == "People")
                do
                {
                    if (action == "Add")
                    do                                                      // Add person            
                    {
                        Console.Clear();
                        _people.Add(new Person());
                        action = AskToContinue(action, entity);

                    } while (action == "Add");

                    else if (action == "View" || action == "Edit")
                    do                            // View and/or Edit person
                    {
                        Console.WriteLine($"These are the available {entity} to {action}: ");
                        foreach(Person item in _people)
                        {
                            Console.WriteLine($"  {item.GetName()}");
                        }
                        Console.Write($"\nEnter the 'name' to {action}: ");
                        string nameEntered = Console.ReadLine();
                        
                        foreach(Person item in _people)
                        {
                            if (nameEntered.ToLower() == item.GetName().ToLower())
                            {
                                if (action == "View")
                                {
                                    Console.Clear();
                                    item.DisplayAvailability();
                                    action = AskToContinue(action, entity);
                                } 
                                
                                else if (action == "Edit")                                     // Edit person
                                {
                                    string change = "y";
                                    while (change == "y")
                                    {
                                        Console.Clear();
                                        item.EditPerson();
                                        action = AskToContinue(action, entity);
                                    }
                                }
                            }                    
                        }
                    } while (action == "View" || action == "Edit");

                    else if (entity == "People" && action == "Save")                                    // Save person
                    {
                        action = AskToContinue(action, entity);
                    }

                    else if (entity == "People" && action == "Load")                                    // Load person
                    {
                        action = AskToContinue(action, entity);
                    }

                    else
                    {entity = "Exit";}                    

                } while (entity == "People");


                else if (entity == "Chores" && action == "Add")                                     // Add chores
                {
                    action = AskToContinue(action, entity);
                }
                
                else if (entity == "Chores" && (action == "View" || action == "Edit"))              // View and/or Edit chores
                {
                    action = AskToContinue(action, entity);
                }
                
                else if (entity == "Chores" && action == "Save")                                    // Save chores
                {
                    action = AskToContinue(action, entity);
                }
                
                else if (entity == "Chores" && action == "Load")                                    // Load chores
                {
                    action = AskToContinue(action, entity);
                }


                else if (entity == "Assignments" && action == "Add")                                // Add assignments
                {
                    action = AskToContinue(action, entity);
                }
                
                else if (entity == "Assignments" && (action == "View" || action == "Edit"))         // View and/or Edit assignments
                {
                    action = AskToContinue(action, entity);
                }
                
                else if (entity == "Assignments" && action == "Save")                               // Save assignments
                {
                    action = AskToContinue(action, entity);
                }
                
                else if (entity == "Assignments" && action == "Load")                               // Load assignments
                {
                    action = AskToContinue(action, entity);
                }
                
            } while (action != "Exit");

        entityChoice = "";
        } while (entityChoice != "Exit");
    }

    public string DisplayMainMenu()
    {
        Console.Write(
@"
Choose an entity:
  1. People
  2. Chores
  3. Assignments
  4. Exit
Select a choice (1-4): ");
        string entity = Console.ReadLine();
        if (entity == "1") {entity = "People";}
        else if (entity == "2") {entity = "Chores";}
        else if (entity == "3") {entity = "Assignments";}
        else if (entity == "4") {entity = "Exit";}
        return entity;
    }

    public (string entity, string action) DisplaySecondMenu(string entity)
    {      
        Console.Write(
@$"
What would you like to do with {entity}:
  1. Add
  2. View
  3. Edit
  4. Save
  5. Load
  6. Exit
Select a choice (1-6): ");
        string action = Console.ReadLine();
        if (action == "1") {action = "Add";}
        else if (action == "2") {action = "View";}
        else if (action == "3") {action = "Edit";}
        else if (action == "4") {action = "Save";}
        else if (action == "5") {action = "Load";}
        else if (action == "6") {action = "Exit";}
        return (entity, action);
    }

    static string AskToContinue (string action, string entity)
    {
        Console.Write($"Do you want to continue to {action} {entity} (y/n)? ");
        if (Console.ReadLine().ToLower() == "n") 
            {return "Exit";}
        else 
            {return action;}
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
