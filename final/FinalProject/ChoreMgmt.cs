using System.Xml.Serialization;

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
        while (entityChoice != "Exit")
        {
            (string entity, string action) = DisplaySecondMenu(entityChoice);
            entityChoice = entity;
            while (action != "Return")
            {
                if (entity == "People")
                    while (entity == "People")
                    {
                        if (action == "Add")
                            while (action == "Add")                                                      // Add person            
                            {
                                Console.Clear();
                                _people.Add(new Person());
                                action = AskToContinue(action, entity);
                            }

                        else if (action == "View" || action == "Edit")
                            while (action == "View" || action == "Edit")                           // View and/or Edit person
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
                                            while (action != "Return")
                                            {                                        
                                                Console.Clear();
                                                item.EditPerson();
                                                action = AskToContinue(action, item.GetName());                                        
                                            }
                                    }                    
                                }
                            }

                        else if (action == "Save")
                            while (action == "Save")                                     // Save person
                            {
                                action = AskToContinue(action, entity);
                            }

                        else if (action == "Load") 
                            while (action == "Load")                                  // Load person
                            {
                                action = AskToContinue(action, entity);
                            }

                        (entity, action) = DisplaySecondMenu(entity);
                        entityChoice = entity;                   
                    }

                else if (entity == "Chores")
                    while (entity == "Chores")
                    {
                        if (action == "Add")
                            while (action == "Add")                                                      // Add person            
                            {
                                Console.Clear();
                                string choreType = $"{ChoreMenu()}";
                                if (choreType == "daily")
                                {
                                    _theChores.Add(new Daily());
                                }
                                else if (choreType == "somedays")
                                {
                                    _theChores.Add(new SomeDays());
                                }
                                else if (choreType == "weekly")
                                {
                                    _theChores.Add(new Weekly());
                                }

                                action = AskToContinue(action, entity);
                            }

                        else if (action == "View" || action == "Edit")
                            while (action == "View" || action == "Edit")                           // View and/or Edit person
                            {
                                Console.WriteLine($"These are the available {entity} to {action}: ");
                                foreach(Chores item in _theChores)
                                {
                                    Console.WriteLine($"  {item.ChoreDetails()}");
                                }
                                Console.Write($"\nEnter the 'name' to {action}: ");
                                string nameEntered = Console.ReadLine();
                                
                                foreach(Chores item in _theChores)
                                {
                                    if (nameEntered.ToLower() == item.GetName().ToLower())
                                    {
                                        if (action == "View")
                                        {
                                            Console.Clear();
                                            item.DisplayChores();
                                            action = AskToContinue(action, entity);
                                        } 
                                        
                                        else if (action == "Edit")                                     // Edit person
                                            while (action != "Return")
                                            {                                        
                                                Console.Clear();
                                                item.EditChore();
                                                action = AskToContinue(action, item.GetName());                                        
                                            }
                                    }                    
                                }
                            }

                        else if (action == "Save")
                            while (action == "Save")                                     // Save person
                            {
                                action = AskToContinue(action, entity);
                            }

                        else if (action == "Load") 
                            while (action == "Load")                                  // Load person
                            {
                                action = AskToContinue(action, entity);
                            }

                        (entity, action) = DisplaySecondMenu(entity);                    
                    }

                else if (entity == "Assignments")
                    while  (action == "Add")                                // Add assignments
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
            }
        } 
    }

    public string DisplayMainMenu()
    {
        Console.Write(
@"
Choose an entity:
  1. People
  2. Chores
  3. Assignments - not built
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
  4. Save - not built
  5. Load - not built
  6. Return to Previous Menu
Select a choice (1-6): ");
        string action = Console.ReadLine();
        if (action != "6")
        {
            if (action == "1") {action = "Add";}
            else if (action == "2") {action = "View";}
            else if (action == "3") {action = "Edit";}
            else if (action == "4") {action = "Save";}
            else if (action == "5") {action = "Load";}
            
            return (entity, action);
        }
        else 
        {
            return ("", "Return");
        }
    }

    static string AskToContinue (string action, string entity)
    {
        Console.Write($"Do you want to continue to {action} {entity} (y/n)? ");
        if (Console.ReadLine().ToLower() == "n") 
            {return "Return";}
        else 
            {return action;}
    }

    public string ChoreMenu()
    {
        Console.WriteLine(
@"How often will this chore need to be done? 
  1. Daily
  2. A few times weekly
  3. Once per week
Enter an option (1-3): 
");
        string choice = Console.ReadLine();
        if (choice == "1")
        {
            return "daily";
        }
        else if (choice == "2")
        {
            return "somedays";
        }
        else if (choice == "3")
        {
            return "weekly";
        }
        else 
        {
            Console.WriteLine("That was not a valid choice.");
            return "";
        }
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
