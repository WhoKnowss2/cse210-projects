public class Comment
{
    private string _name;
    private string _comment;

    public Comment(string name, string text)
    {
        _name = name;
        _comment = text;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetText()
    {
        return _comment;
    }
}