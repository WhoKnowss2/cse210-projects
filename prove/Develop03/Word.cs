class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // Count only letters for underscore length
            string letters = StripPunctuation(_text);
            string underscores = new string('_', letters.Length);

            // Re-attach punctuation at the end if any
            string punctuation = _text.Substring(letters.Length);
            return underscores + punctuation;
        }
        else
        {
            return _text;
        }
    }

    private string StripPunctuation(string text)
    {
        string result = text;
        while (result.Length > 0 && !char.IsLetter(result[result.Length - 1]))
        {
            result = result.Substring(0, result.Length - 1);
        }
        return result;
    }
}
