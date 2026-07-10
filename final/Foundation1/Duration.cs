namespace Foundation1;

public class Duration {
    private double _minutes;
    private double _seconds;

    public Duration(double minutes, double seconds) {
        _minutes = minutes;
        _seconds = seconds;
    }

    public String Display() {
        return $"{Minutes:0}:{Seconds:00}";
    }

    public double Minutes {
        get => _minutes;
        set => _minutes = value;
    }

    public double Seconds {
        get => _seconds;
        set => _seconds = value;
    }
}