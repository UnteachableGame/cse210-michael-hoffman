namespace Foundation4;

public class Swimming : Activity {
    private int _numberOfLaps;

    public Swimming(int lengthInMinutesInMinutes, int numberOfLaps) : base(lengthInMinutesInMinutes) {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance() {
        return NumberOfLaps * 50.0 / 1000.0 * 0.62;
    }

    public override double GetSpeed() {
        return (GetDistance() / LengthInMinutes) * 60.0;
    }

    public override double GetPace() {
        return LengthInMinutes / GetDistance();
    }

    public int NumberOfLaps {
        get => _numberOfLaps;
        set => _numberOfLaps = value;
    }
}