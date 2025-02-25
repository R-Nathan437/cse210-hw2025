public class Listing : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who do you look up to?",
        "What are your personal strengths?",
        "Who have you helped this week?",
        "When have you felt the Holy Ghost this month?",
    };
    private string _prompt;
    public Listing() : base()
    {
        SetActivityName("Listing Activity");
        SetActivityDescription("Reflect on a prompt and list your responses to it. ");

    }
    public void DisplayPrompt()
    {
        Console.WriteLine("");
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count());
        _prompt = _prompts[randomIndex];
        Console.WriteLine($"Prompt: {_prompt}");
    }
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
        RunStart();
        DisplayPrompt();
        DisplayReady();
        AnswerPrompt();
        DisplayEnd();
    }
    
}