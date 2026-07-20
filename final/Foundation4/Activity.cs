public class Activity
{
    private string _date;
    private int _minutes;
    private string _activityType;

    public Activity(string date, int minutes, string activityType)
    {
        _date = date;
        _minutes = minutes;
        _activityType = activityType;
    }

    protected int GetMinutes()
    {
        return _minutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public string GetSummary()
    {
        double distance = Math.Round(GetDistance(), 2);
        double speed = Math.Round(GetSpeed(), 2);
        double pace = Math.Round(GetPace(), 2);

        return $"{_date} {_activityType} ({_minutes} min): " +
               $"Distance {distance} km, Speed: {speed} kph, " +
               $"Pace: {pace} min per km";
    }
}