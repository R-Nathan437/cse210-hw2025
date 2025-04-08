public class Outdoor : Event
{
    private string _weather;
    public string weather
    {
        get{return _weather;}
        set{_weather = value;}
    }
    public Outdoor(string title, string description, string date, string time, Address address, int numnberAttendees, string weather) : base(title, description, date, time, address, numnberAttendees)
    {
        _weather = weather;
        _type = "Outdor";
    }
    public void DisplayOutdoor()
    {
        Console.WriteLine($"{title}\n{description}\n{date}|{time}\n||{weather}||\n\n{address.FullAddress()}\n");
    }
}