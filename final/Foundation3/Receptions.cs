namespace Foundation3;

public class Receptions : Event {
    private bool _hasRsvped;
    private bool _hasRegistered;
    private String _email;

    public Receptions(string eventTitle, string description, Address address, bool hasRsvped, bool hasRegistered) : base(eventTitle, description, address) {
        _hasRsvped = hasRsvped;
        _hasRegistered = hasRegistered;
        EventType = "Receptions";
    }

    public String DisplayRsvpDetails() {
        return DisplayFullDetails() + 
               $"\n{Email}";
    }

    public bool HasRsvped {
        get => _hasRsvped;
        set => _hasRsvped = value;
    }

    public bool HasRegistered {
        get => _hasRegistered;
        set => _hasRegistered = value;
    }

    public string Email {
        get => _email;
        set => _email = value;
    }
}