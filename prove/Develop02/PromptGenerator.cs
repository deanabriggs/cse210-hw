public class PromptGenerator
{
    // create a variable for the list and 
    public List<string> _prompts = new List<string>()
    {
        // add prompts to the list
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is one thing I am grateful for today?",
        "Who did I serve or show kindness towards today?",
        "What is one thing I accomplished today?",
        "How did I follow Jesus' example today?",
        "How did I take care of my health today?",
        "How did I express appreciation to someone else today?"
    };    

    // functions for the class 
    public string GetRandomPrompt()
    {
        Random randomNumber = new Random();
        int number = randomNumber.Next(0, _prompts.Count);
        return _prompts[number];   
    }

}