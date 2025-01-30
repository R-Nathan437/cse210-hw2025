public class Entry
{
    public string _prompt;
    public string _date;
    public string _text;
    List<string> _prompts = new List<string>()
        {
            "What are some recent challenges?",
	        "What has made you smile recently?",
		    "If you could plan out your perfect day, what would you do?",
		    "If you sat down for lunch with your 10-year-old self, what would you say?",
		    "What's a quality you look for in a friend? Do you display this yourself?",
		    "Write about a time when you helped someone through something.",
		    "What's a memory you cherish?"
        };
    public void GeneratePrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count());
        _prompt = _prompts[randomIndex];
        Console.WriteLine($"Prompt: {_prompt}");
    }
    public void GenerateDate()
    {
        DateTime currentTime = DateTime.Now;
        _date = currentTime.ToShortDateString();
    }
    public void GetText()
    {
        Console.Write("   ");
        _text = Console.ReadLine();
    }
}




///Entry
///get prompt
///take user input
/// each entry has a prompt, date and 'entry'