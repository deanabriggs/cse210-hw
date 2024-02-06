using System.Data;

class Activity
{
    // Variables / Attributes
    protected string _name;
    protected string _description;
    protected int _duration;

    // Constructors
    protected Activity()
    {}

    // Functions / Methods
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.\n");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        DateTime currentTime = startTime;
        
        List<string> animation = new List<string>()
        {"|", "/", "-", "\\"};
    
        while (currentTime < endTime)
        {
            foreach(string a in animation)
            {
                Console.Write(a);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }       
            currentTime = DateTime.Now;
        }
        Console.Write("\b \b");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.Write(" ");
    }
}