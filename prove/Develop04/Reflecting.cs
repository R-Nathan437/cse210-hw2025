public class Reflecting: Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>()
    {
        "How did you get started?",
        "What is your favorite thing about this experience?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
        "Why was this experience meaningful to you?"
    };
    

    public Reflecting() : base()
    {
        SetActivityName("Reflecting Activiy");
        SetActivityDescription("Reflect on your day");

    }
    public void RunReflecting()
    {
        RunStart();
        DisplayPrompt();
        DisplayQuestion();
        DisplayEnd();
    }
    public void DisplayPrompt()
    {
        if (Getlength() < 15)
        {
            Console.WriteLine("Activity runs a minimun of 15 seconds.\n");
            SetLength(15);
        }
        int randomIndex = new Random().Next(0, _prompts.Count());
        Console.WriteLine($"Ponder this: {_prompts[randomIndex]}");
        Animation(5);
    }
    public void DisplayQuestion()
    {
        for (int i = 1; i <= (Getlength() - 5)/5; i++)
        {
            int randomIndex = new Random().Next(0, _questions.Count());
            Console.WriteLine(_questions[randomIndex]);
            Animation(5);
            _questions.Remove(_questions[randomIndex]);
        }
    }
}