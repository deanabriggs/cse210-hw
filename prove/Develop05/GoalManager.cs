using System.Runtime.InteropServices;

public class GoalManager
{
    // Variables / Attributes
    private List<Goal> _goals;
    private int _score;      // Stores the Cumulative Score

    // Constructors
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    // Functions / Methods
    public void Start()
    {      
        string userChoice = "";
        while (userChoice != "6")
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();
        }
    }

    public void DisplayPlayerInfo()     // DONE - writes current score to the console (adds blank line at end)
    {
        Console.WriteLine($"You have {_score} points.\n");
    }

    public void ListGoalNames()         // not sure what this will be used for, will require me to write a "getter" function
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goal}");
        }
    }

    public void ListGoalDetails()       // DONE - writes goal details to the console, includes status
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void CreateGoal()
    {

    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }

}