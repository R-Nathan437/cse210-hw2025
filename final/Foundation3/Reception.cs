public class Reception : Event
{
    private string _userEmail;
    public string userEmail
    {
        get{return _userEmail;}
        set{_userEmail = value;}
    }
    private string _eventEmail;
    public string eventEmail
    {
        get{return _eventEmail;}
        set{_eventEmail = value;}
    }
   
    public Reception(string title, string description, string date, string time, Address address, int numberAttendees, string eventEmail) : base(title, description, date, time, address, numberAttendees)
    {
        _eventEmail = eventEmail;
        _numberAttendees = 0;
        _type = "Reception";
    }
    public void Rsvp()
    {
        Console.WriteLine("Will you be attending?\n Type: Y for yes || Type: N for no");
        string response = Console.ReadLine().ToLower();
        bool running = true;
        while (running)
        {
            if (response == "y")
            {
                Console.WriteLine("What is your email:");
                userEmail = Console.ReadLine();
                Console.WriteLine("Thank you for your RSVP");
                numberAttendees++;
                running = false;
            }
            else if (response == "n")
            {
                Console.WriteLine("Thank you for your RSVP");
                running = false;
            }
            else
            {
                Console.WriteLine("invalid input. Please type 'Y' or 'N'.");
            }
        }
    }
    public void DisplayReception()
    {
         Console.WriteLine($"{title}\n{description}\n{date}|{time}\n\n{address.FullAddress()}\n{eventEmail} || {numberAttendees}: RSVP'S\n");
    }
}