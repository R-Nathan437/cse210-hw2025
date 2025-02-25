public class Reflecting: Activity
{
    /// <summary>
    /// Refelcting activity shows you an initial prompt and then asks a question about the prompt. The animation runs during the time you are given to reflect
    /// </summary>
    /// attributes: prompts and questions that appply to all prompts
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
    
    //reflection constructor, uses base activity and sets name and desciption
    public Reflecting() : base()
    {
        SetActivityName("Reflecting Activiy");
        SetActivityDescription("Reflect on your day");

    }
    //display prompt and let the user look at it for a second while the mehtod runs an animation
    public void DisplayPrompt()
    {
        if (_length < 15)
        {
            Console.WriteLine("Activity runs a minimun of 15 seconds.\n");
            SetLength(15);
        }
        int randomIndex = new Random().Next(0, _prompts.Count());
        Console.WriteLine($"Ponder this: {_prompts[randomIndex]}");
        Animation(5);
    }
    //display the question to the prompt every 5 seconds inbetween animations untill the time is up.
    public void DisplayQuestion()
    {
        for (int i = 1; i <= (_length - 5)/5; i++)
        {
            int randomIndex = new Random().Next(0, _questions.Count());
            Console.WriteLine(_questions[randomIndex]);
            Animation(5);
            _questions.Remove(_questions[randomIndex]);
        }
    }
    public void RunReflecting()
    {
        RunStart();//start message, set user length, get ready
        DisplayPrompt();//part 1 reflect
        DisplayQuestion();//part 2 reflect
        DisplayEnd();// end message
    }
}