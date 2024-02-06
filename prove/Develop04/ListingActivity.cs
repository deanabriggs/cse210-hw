class ListingActivity : Activity
{
    // Variables / Attributes
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    // Constructors
    public ListingActivity()
    {}

    // Functions / Methods
    public void Run()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        DisplayStartingMessage();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        GetListFromUser();
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random randomNumber = new Random();
        int number = randomNumber.Next(0, _prompts.Count);
        Console.WriteLine($" --- {_prompts[number]} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
    }
    
    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = startTime;

        List<string> userList = new List<string>();
        while (currentTime < endTime)
        {
            Console.Write("> ");
            userList.Add(Console.ReadLine());
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {userList.Count()} items!");
        return userList;
    }
}