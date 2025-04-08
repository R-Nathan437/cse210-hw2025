public class Lecture : Event
{
    private string _speaker;
    public string speaker
    {
        get{return _speaker;}
        set{_speaker = value;}
    }
    private int _capacity;
    public int capacity
    {
        get{return _capacity;}
        set{_capacity = value;}
    }
    public Lecture(string title, string description, string date, string time, Address address, int numberAttendees, int capacity, string speaker) : base(title, description, date, time, address, numberAttendees)
    {
        _capacity = capacity;
        _speaker = speaker;
        _type = "Lecture";
    }
    public void DisplayLecture()
    {
        Console.WriteLine($"{title} | {speaker}\n{description}\n{date}|{time}\n\n{address.FullAddress()}\n\n {numberAttendees}/{capacity} Capacity");
    }
}