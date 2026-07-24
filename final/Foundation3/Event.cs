namespace Foundation3;

public class Event {
    protected String _eventTitle;
    protected String _description;
    protected DateTime _time;
    protected Address _address;
    protected String _eventType;
    protected DateTime _date;

    public Event(string eventTitle, string description, Address address) {
        _eventTitle = eventTitle;
        _description = description;
        _time = DateTime.Now;
        _address = address;
        _date = DateTime.Today;
    }

    public String DisplayStandardDetails() {
        return $"{EventTitle} - {Date}\n" +
               $"{Time}\n" +
               $"{Address.DisplayAddress()}\n" +
               $"{Description}";
    }

    public String DisplayFullDetails() {
        return DisplayStandardDetails() + $"{EventType}";
    }

    public String DisplayShortDetails() {
        return $"{EventTitle} - {Date}\n" +
               $"{EventType}";
    }

    public string EventTitle {
        get => _eventTitle;
        set => _eventTitle = value;
    }

    public string Description {
        get => _description;
        set => _description = value;
    }

    public DateTime Time {
        get => _time;
        set => _time = value;
    }

    public Address Address {
        get => _address;
        set => _address = value;
    }

    public string EventType {
        get => _eventType;
        set => _eventType = value;
    }

    public DateTime Date {
        get => _date;
        set => _date = value;
    }
}