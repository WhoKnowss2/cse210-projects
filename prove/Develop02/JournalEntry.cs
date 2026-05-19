public class JournalEntry
{
    private string _date;
    private string _prompt;
    private string _response;

    // Constructor
    public JournalEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt}");
        Console.WriteLine(_response);
        Console.WriteLine();
    }

    public string CreateFileSystemString()
    {
        return $"{_date}|{_prompt}|{_response}";
    }
}