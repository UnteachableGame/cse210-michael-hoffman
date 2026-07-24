namespace Foundation4;

public class Running : Activity {
    private double _distance;

    public Running(int lengthInMinutesInMinutes, double distance) : base(lengthInMinutesInMinutes) {
        _distance = distance;
    }

    public override double GetDistance() {
        return Distance;
    }

    public override double GetSpeed() {
        return (Distance / LengthInMinutes) * 60;
    }

    public override double GetPace() {
        return LengthInMinutes / GetDistance();
    }

    public double Distance {
        get => _distance;
        set => _distance = value;
    }
}