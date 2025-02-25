public class Listing : Activity
{
    /// <summary>
    /// Listing activity calls a prompt and gets you to list a number of answeres based on that prompt. 
    /// </summary>
    /// attribute: list of prompts
    private List<string> _prompts = new List<string>
    {
        "Who do you look up to?",
        "What are your personal strengths?",
        "Who have you helped this week?",
        "When have you felt the Holy Ghost this month?",
    };
    private string _prompt;
    //Listing constuctor uses base constructor and sets the name and description
    public Listing() : base()
    {
        SetActivityName("Listing Activity");
        SetActivityDescription("Reflect on a prompt and list your responses to it. ");

    }
    //displays a random prompt
    public void DisplayPrompt()
    {
        Console.WriteLine("");
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count());
        _prompt = _prompts[randomIndex];
        Console.WriteLine($"Prompt: {_prompt}");
    }
    //user lists answers while the method keeps a tally of how many times the enter key is hit
    public void AnswerPrompt()
    {
        Console.WriteLine(_prompt);
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(Getlength());
        int count = 0;
        while (DateTime.Now < end)
        {
            Console.Write("---");
            Console.ReadLine();
            count += 1;
        }
        Console.WriteLine("Counting: ");
        Animation(3);
        Console.WriteLine($"\nYou listed {count} items");
    }
   
    public void RunListing()
    {
        RunStart();//start message, user set length, get ready
        DisplayPrompt();//displayprompt
        DisplayReady();//get ready again
        AnswerPrompt();//list answers
        DisplayEnd();//end message
    }
    
}