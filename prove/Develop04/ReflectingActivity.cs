using System.Security.Cryptography;

class ReflectingActivity : Activity
{
    // Variables / Attributes
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    // Constructors
    public ReflectingActivity()
    {}

    // Functions / Methods
    public void Run()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have an how you can use it in other aspects of your life.";
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random randomNumber = new Random();
        int number = randomNumber.Next(0, _prompts.Count);
        return _prompts[number];   
    }

    private string GetRandomQuestion()
    {
        Random randomNumber = new Random();
        int number = randomNumber.Next(0, _questions.Count);
        return _questions[number];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void DisplayQuestions()
    {
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(3);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = startTime;
        
        while (currentTime < endTime)
        {
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(7);
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
    }
}