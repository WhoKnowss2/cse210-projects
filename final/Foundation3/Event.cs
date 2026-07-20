public abstract class Event
{
    private string _eventType;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    protected Event(
        string eventType,
        string title,
        string description,
        string date,
        string time,
        Address address)
    {
        _eventType = eventType;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\n" +
               $"Description: {_description}\n" +
               $"Date: {_date}\n" +
               $"Time: {_time}\n" +
               $"Address:\n{_address.GetAddress()}";
    }

    public string GetShortDescription()
    {
        return $"{_eventType}: {_title} — {_date}";
    }

    public abstract string GetFullDetails();
}