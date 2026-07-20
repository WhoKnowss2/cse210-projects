public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(
        string title,
        string description,
        string date,
        string time,
        Address address,
        string weather)
        : base("Outdoor Gathering", title, description, date, time, address)
    {
        _weather = weather;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\n" +
               $"Event type: Outdoor Gathering\n" +
               $"Weather forecast: {_weather}";
    }
}