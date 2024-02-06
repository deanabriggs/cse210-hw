class BreathingActivity : Activity
{
    // Variables / Attributes

    // Constructors
    public BreathingActivity()
    {}

    // Functions / Methods
    public void Run()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        DisplayStartingMessage();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime;
        
        do {
        Console.WriteLine();
        Console.Write("Breathe in...");
        ShowCountDown(2);

        Console.WriteLine();
        Console.Write("Now breathe out...");
        ShowCountDown(3);

        Console.WriteLine();
        currentTime = DateTime.Now;

        } while (currentTime < endTime);

        DisplayEndingMessage();
    }
}