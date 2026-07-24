namespace Foundation3;

public class OutdoorGatherings : Event {
    private String _weatherForecast;

    public OutdoorGatherings(string eventTitle, string description, Address address, string weatherForecast) : base(eventTitle, description, address) {
        _weatherForecast = weatherForecast;
        EventType = "Outdoor Gatherings";
    }

    public String DisplayOutdoorGatheringDetails() {
        return DisplayFullDetails() + 
               $"\n{WeatherForecast}";
    }

    public string WeatherForecast {
        get => _weatherForecast;
        set => _weatherForecast = value;
    }
}