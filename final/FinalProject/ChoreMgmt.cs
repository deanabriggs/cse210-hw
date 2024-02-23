using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
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
        string entityOrExit = DisplayMainMenu();
        do
        {
            (string entity, string action) = DisplaySecondMenu(entityOrExit);
            entityOrExit = entity;                                           
            while (entity != "Exit")                       
            {
                while (entity == "People")
                {
                    while (action == "Add")                                   // Add person            
                    {
                        _people.Add(new Person());

                        (entity, action) = AskToContinue(entity, action);
                    }

                    while (action == "View" || action == "Edit")              // View and/or Edit person
                    {
                        Console.WriteLine($"These are the available {entity} to {action}: ");
                        DisplayPeople();

                        Console.Write($"\nEnter the 'number' to {action}: ");  // Choose person
                        int index = int.Parse(Console.ReadLine())-1;
                        Person thePerson = _people[index];

                        thePerson.DisplayAvailability();                       
                        
                        while (action == "View")                                // View
                        {
                            (entity, action) = AskToContinue(entity, action);
                        } 
                        while (action == "Edit")                                // Edit
                        { 
                            thePerson.EditPerson();
                            (entity, action) = AskToContinue(entity, action);
                        }                                                 
                        
                        (entity, action) = DisplaySecondMenu(entity);
                    }

                    while (action == "Save")                                  // Save person
                    {
                        (entity, action) = AskToContinue(entity, action);
                    }

                    while (action == "Load")                                  // Load person
                    {
                        (entity, action) = AskToContinue(entity, action);
                    }

                    if (action == "Return")
                    {
                        (entity, action) = DisplaySecondMenu(entity);
                        entityOrExit = entity; 
                    }
                }

                while (entity == "Chores")
                {
                    while (action == "Add")                                   // Add chore          
                    {
                        Console.Clear();
                        string choreType = ChoreMenu();
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

                        (entity, action) = AskToContinue(entity, action);
                    }

                    while (action == "View" || action == "Edit" )              // View and/or Edit chore 
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
                                while (action == "View")
                                {
                                    Console.Clear();
                                    item.DisplayChores();
                                    (entity, action) = AskToContinue(entity, action);
                                } 
                                
                                while (action == "Edit")                                     // Edit person
                                {                                        
                                    Console.Clear();
                                    item.EditChore();
                                    (entity, action) = AskToContinue(entity, action);                                     
                                }
                            }                    
                        }
                        (entity, action) = DisplaySecondMenu(entity);
                    }

                    while (action == "Save")                                  // Save person
                    {
                        (entity, action) = AskToContinue(entity, action);
                    }

                    while (action == "Load")                                  // Load person
                    {
                        (entity, action) = AskToContinue(entity, action);
                    }
                    
                    if (action == "Return")
                    {
                        (entity, action) = DisplaySecondMenu(entity);
                        entityOrExit = entity; 
                    }           
                }

                while (entity == "Assignments")
                {
                    while  (action == "Add")                                // Add assignments
                    {
                        (entity, action) = AskToContinue(entity, action);
                    }
                
                    while (action == "View" || action == "Edit")            // View and/or Edit assignments
                    {
                        (entity, action) = AskToContinue(entity, action);
                    }
                
                    while (action == "Save")                               // Save assignments
                    {
                        (entity, action) = AskToContinue(entity, action);
                    }
                
                    while (action == "Load")                               // Load assignments
                    {
                        (entity, action) = AskToContinue(entity, action);
                    }

                    if (action == "Return")
                    {
                        (entity, action) = DisplaySecondMenu(entity);
                        entityOrExit = entity; 
                    }                  
                }
                if (entity == "Done")
                {
                    entityOrExit = DisplayMainMenu();
                    (entity, action) = DisplaySecondMenu(entityOrExit);
                };
            }
        
        } while(entityOrExit != "Exit");
    }

    public string DisplayMainMenu()
    {
        Console.Write(
@"                         CHORE ASSIGNMENT PROGRAM
                        Managing Your Family Chores
                        
Choose an entity:
  1. People
  2. Chores
  3. --Assignments--
  4. Exit

Select a choice (1-4): ");
        string entity = Console.ReadLine();
        Console.Clear();
        if (entity == "1") 
        {
            return "People";
        }
        else if (entity == "2") 
        {
            return "Chores";
        }
        else if (entity == "3") 
        {
            return "Assignments";
        }
        else if (entity == "4") 
        {
            return "Exit";
        }
        else return "Exit";
    }

    public (string entitiyOrExit, string actionOrDone) DisplaySecondMenu(string entityOrExit)
    {   
        if (entityOrExit == "Exit") {return ("Exit", "Done");}
        else 
        {
            Console.Write(
@$"                         CHORE ASSIGNMENT PROGRAM
                        Managing Your Family Chores

What would you like to do with {entityOrExit.ToUpper()}:
  1. Add
  2. View
  3. Edit
  4. --Save--
  5. --Load--
  6. Done with {entityOrExit}

Select a choice (1-6): ");
            string action = Console.ReadLine();
            Console.Clear();
            
            if (action == "1") 
            {
                return (entityOrExit, "Add");
            }
            else if (action == "2") 
            {
                return (entityOrExit, "View");
            }
            else if (action == "3") 
            {
                return (entityOrExit, "Edit");
            }
            else if (action == "4") 
            {
                return (entityOrExit, "Save");
            }
            else if (action == "5") 
            {
                return (entityOrExit, "Load");
            }
            else if (action == "6") 
            {
                return ("Done", "Return");
            }
            else 
            {
                return ("Done", "Return");
            }
        }
    }

    static (string entity, string action) AskToContinue (string entity, string action)
    {
        if (entity == "Exit" || action == "Done") 
        {
            return (entity, action);
        }
        
        Console.Write($"\nDo you want to continue to {action.ToUpper()} {entity} (y/n)? ");
        string choice = Console.ReadLine().ToLower();
        Console.Clear();
        if (choice == "y")
        {
            return (entity, action);
        }
        return (entity, "Return");
    }

    public string ChoreMenu()
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
        int i = 0;
        foreach(Person item in _people)
        {
            i++;
            Console.WriteLine($"  {i}. {item.GetName()}");
        }
    }

    public void DisplayChores()
    {
        int i = 0;
        foreach(Chores item in _theChores)
        {
            i++;
            Console.WriteLine($"  {i}. {item.GetName()}");
        }
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
