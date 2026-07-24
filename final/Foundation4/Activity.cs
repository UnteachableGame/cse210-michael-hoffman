using System.Globalization;

namespace Foundation4;

public class Activity {
    protected String _date;
    protected int lengthInMinutesInMinutes;

    public Activity(int lengthInMinutesInMinutes) {
        this.lengthInMinutesInMinutes = lengthInMinutesInMinutes;
        _date = DateTime.Today.ToString("dd MMM yyyy", CultureInfo.InvariantCulture);
    }

    public void GetSummary() {
        Console.WriteLine($"{Date} {GetType().Name} ({LengthInMinutes} min)- Distance: {GetDistance():F1}, Speed: {GetSpeed():F1}, Pace: {GetPace():F1} min per mile");
    }

    public virtual double GetDistance() {
        return 0;
    }
    
    public virtual double GetSpeed() {
        return 0;
    }
    
    public virtual double GetPace() {
        return 0;
    }

    public String Date {
        get => _date;
        set => _date = value;
    }

    public int LengthInMinutes {
        get => lengthInMinutesInMinutes;
        set => lengthInMinutesInMinutes = value;
    }
}