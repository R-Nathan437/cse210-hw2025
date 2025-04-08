public class Event
{
    protected string _title;
    public string title
    {
        get{return _title;}
        set{_title = value;}
    }
    protected string _description;
    public string description
    {
        get{return _description;}
        set{_description = value;}
    }
    protected string _date;
    public string date
    {
        get{return _date;}
        set{_date = value;}
    }
    protected string _time;
    public string time
    {
        get{return _time;}
        set{_time = value;}
    }
    protected Address _address;
    public Address address
    {
        get{return _address;}
        set{_address = value;}
    }
    protected string _type;
    public string type
    {
        get{return _type;}
        set{_type = value;}
    }
    protected int _numberAttendees;
    public int numberAttendees
    {
        get{return _numberAttendees;}
        set{_numberAttendees = value;}
    }

    public Event(string title, string description, string date, string time, Address address, int numberAttendees)
    {
        _title = title;
       _description = description;
        _date = date;
        _time = time;
        _address = address;
        _numberAttendees = numberAttendees;
        
    }
    public void DisplayStandard()
    {
        Console.WriteLine($"\n{title}\n{description}\n{date}|{time}\n\n{address.FullAddress()}");
    }
    public void DisplayShort()
    {
        Console.WriteLine($"\n{type}  {title}\n{date}");
    }

}