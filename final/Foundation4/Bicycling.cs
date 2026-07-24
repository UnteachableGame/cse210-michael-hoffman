namespace Foundation4;

public class Bicycling : Activity {
    private int _speed;
    
    public Bicycling(int lengthInMinutesInMinutes, int speed) : base(lengthInMinutesInMinutes) {
        _speed = speed;
    }

    public override double GetDistance() {
        return (Speed / LengthInMinutes) * 60.0;
    }

    public override double GetSpeed() {
        return Speed;
    }

    public override double GetPace() {
        return 60.0 / Speed;
    }

    public int Speed {
        get => _speed;
        set => _speed = value;
    }
}