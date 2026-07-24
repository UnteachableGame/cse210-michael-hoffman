namespace Foundation3;

public class Lecture : Event {
    private String _speaker;
    private int _capacity;

    public Lecture(string eventTitle, string description, Address address, string speaker, int capacity) : base(eventTitle, description, address) {
        _speaker = speaker;
        _capacity = capacity;
        EventType = "Lecture";
    }

    public String DisplayLectureDetails() {
        return DisplayFullDetails() + 
               $"\n{Speaker}\n" +
               $"{Capacity}";
    }

    public string Speaker {
        get => _speaker;
        set => _speaker = value;
    }

    public int Capacity {
        get => _capacity;
        set => _capacity = value;
    }
}