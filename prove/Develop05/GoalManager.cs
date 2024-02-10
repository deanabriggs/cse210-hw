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
        string userInput = "";
        while (userInput != "6")
        {
            Console.WriteLine();
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                CreateGoal();
            }
            else if (userInput == "2")
            {
                ListGoalDetails();
            }
            else if (userInput == "3")
            {
                SaveGoals();
            }
            else if (userInput == "4")
            {
                LoadGoals();
            }
            else if (userInput == "5")
            {
                RecordEvent();
            }
        }
    }

    public void DisplayPlayerInfo()     // DONE - writes current score to the console (adds blank line at end)
    {
        Console.WriteLine($"You have {_score} points.\n");
    }

    public void ListGoalNames()         // DONE - for list menu - used in RecordEvent function
    {
        Console.WriteLine("The goals are:");
        int showNumber = 0;
        foreach (Goal goal in _goals)
        {
            showNumber += 1;
            Console.WriteLine($" {showNumber}. {goal.getName()}");
        }
    }

    public void ListGoalDetails()       // DONE - writes goal details to the console, includes status
    {
        Console.WriteLine("\nThe goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()            // DONE
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.WriteLine("Press 'enter' to return to the previous menu.");
        Console.Write("Which type of goal would you like to create? ");
        string userChoice = Console.ReadLine();
        Console.WriteLine();

        if (userChoice == "1")
        {
            var values = RequestBaseGoalInfo();     // static function to ask questions and obtain data for base class
            SimpleGoal newSimple = new SimpleGoal(values.Item1, values.Item2, values.Item3);
            _goals.Add(newSimple);
        }
        else if (userChoice == "2")
        {
            var values = RequestBaseGoalInfo();     // static function to ask questions and obtain data for base class
            EternalGoal newEternal = new EternalGoal(values.Item1, values.Item2, values.Item3);
            _goals.Add(newEternal);
        }
        else if (userChoice == "3")
        {
            var values = RequestBaseGoalInfo();     // static function to ask questions and obtain data for base class
            
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            
            ChecklistGoal newChecklist = new ChecklistGoal(values.Item1, values.Item2, values.Item3, target, bonus);
            _goals.Add(newChecklist);
        }
    }

    public void RecordEvent()           // DONE - updates complete status and adds points
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int userChoice = int.Parse(Console.ReadLine())-1;  // finds the index for the goal selected
        _score += _goals[userChoice].RecordEvent();
        celebrate();
    }

    public void SaveGoals()             // DONE
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach(Goal each in _goals)
            {
                outputFile.WriteLine(each.GetStringRepresentation());
            }
        }
        Console.WriteLine("\nYour file has been saved.");
    }

    public void LoadGoals()             // DONE
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        _score = int.Parse(lines.FirstOrDefault());

        IEnumerable<string> savedGoals = lines.Skip(1); // create list skipping the score line
        foreach (string line in savedGoals)
        {
            string[] parts = line.Split(":");           // split the line to separate type of goal from goal detail
            string typeGoal = parts[0];                 // set type of goal to a variable
            string goalDetail = parts[1];               // set string of goal detail to a variable
            string[] goalParts = goalDetail.Split("|"); // split the goal detail

            // Assign variables to base goal attributes
            string name = goalParts[0];
            string description = goalParts[1];
            int points = int.Parse(goalParts[2]);
            
            if (typeGoal == "SimpleGoal")
            {
                bool complete = bool.Parse(goalParts[3]);
                SimpleGoal loadSimple = new SimpleGoal(name, description, points, complete);
                _goals.Add(loadSimple);
            }
            else if (typeGoal == "EternalGoal")
            {
                EternalGoal loadEternal = new EternalGoal(name, description, points);
                _goals.Add(loadEternal);
            }
            else if (typeGoal == "ChecklistGoal")
            {
                int completed = int.Parse(goalParts[3]);
                int target = int.Parse(goalParts[4]);
                int bonus = int.Parse(goalParts[5]);
                ChecklistGoal loadChecklist = new ChecklistGoal(name, description, points, target, bonus, completed);
                _goals.Add(loadChecklist);
            }
        }
    }

    static (string, string, int) RequestBaseGoalInfo()  // obtains values from user for attributes that all goals have in common (base class)
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        return (name, description, points);
    }

    static void celebrate()
    {
        List<string> awards = new List<string>()
        {
            "Good Job!",
            "Amazing!",
            "Way to Go!",
            "You did it!",
            "Excellent!",
            "Keep it up!",
            "Wow!",
            "That's the Spirit!"
        };
        
        Random randomNum = new Random();
        int number = randomNum.Next(0, awards.Count);
        string praise = awards[number];

        
        Console.Clear();
        Thread.Sleep(200);
        
        Console.WriteLine($"\n\n\n\n                            {praise}");
        Thread.Sleep(500);
        Console.Clear();
        
        Console.WriteLine($"\n\n            {praise}");
        Thread.Sleep(500);
        Console.Clear();
        
        Console.WriteLine($"\n\n\n\n\n\n\n                                {praise}");
        Thread.Sleep(500);
        Console.Clear();
        
        Console.WriteLine($"\n                                              {praise}");
        Thread.Sleep(500);
        Console.Clear();
        
        Console.WriteLine($"\n\n\n\n\n\n                                        {praise}");
        Thread.Sleep(500);
        Console.Clear();
        
        Console.WriteLine($"\n\n\n\n\n              {praise}");
        Thread.Sleep(500);
        Console.Clear();
        
        Console.WriteLine($"\n\n\n                                  {praise}");
        Thread.Sleep(500);
        Console.Clear();
        
        Console.WriteLine($"\n\n\n\n\n\n\n\n                    {praise}");
        Thread.Sleep(500);
        Console.Clear();
        
        Console.WriteLine($"                        {praise}");
        Thread.Sleep(500);
        Console.Clear();
        Thread.Sleep(200);
        Console.WriteLine($"\n\n\n\n                            {praise.ToUpper()}");
        Thread.Sleep(1000);
        Console.Clear();
    }

}