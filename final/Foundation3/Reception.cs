public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(
        string title,
        string description,
        string date,
        string time,
        Address address,
        string rsvpEmail)
        : base("Reception", title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\n" +
               $"Event type: Reception\n" +
               $"RSVP email: {_rsvpEmail}";
    }
}