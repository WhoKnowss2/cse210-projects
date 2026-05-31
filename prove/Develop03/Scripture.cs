using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private Word[] _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] parts = text.Split(' ');
        _words = new Word[parts.Length];

        for (int i = 0; i < parts.Length; i++)
        {
            _words[i] = new Word(parts[i]);
        }
    }

    public string GetDisplayText()
    {
        string wordLine = "";
        foreach (Word word in _words)
        {
            wordLine += word.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()}\n{wordLine.Trim()}";
    }

    public void HideRandomWords(int count)
    {
        // Build a list of only the visible words
        List<Word> visible = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                visible.Add(word);
        }

        Random random = new Random();
        int toHide = Math.Min(count, visible.Count);

        for (int i = 0; i < toHide; i++)
        {
            int index = random.Next(visible.Count);
            visible[index].Hide();
            visible.RemoveAt(index);
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}
