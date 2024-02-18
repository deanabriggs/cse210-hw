public class ChoreMgmt
{
    public ChoreMgmt()
    {}

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
            Console.Write(
@"Menu Options:
1. Add/Edit a person
2. Add/Edit a chore
3. Assign Chores
4. Save your chore list
5. Load an existing chore list
6. View Chore List
7. View Unassigned Chores
8. View Time Availability
9. Exit the program
Select a choice from the menu: ");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.Write("Type '1' to add or '2' to edit ");
                string userChoice = Console.ReadLine();
                    if (userChoice == "1")
                    {
                        AddPerson();
                    }

            }

        }
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

    public Person AddPerson()
    {
        Console.Write("Enter the name of the person that will do chores. ");
        string name = Console.ReadLine();
        Console.Write("What is their birthday? ");
        DateOnly dob = DateOnly.Parse(Console.ReadLine());
        Console.Write("About how much TIME do they have to do chores each day (in minutes)? ");
        int minutes = int.Parse(Console.ReadLine());
        List<Availability> newAvailable = new List<Availability>();
        for (int i=0; i < 7; i++)
        {
            Availability day = new Availability(i, minutes);
            newAvailable.Add(day);
        }
        return new Person(name, dob, newAvailable);       
    }


}
