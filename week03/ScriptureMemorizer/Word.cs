using System;

class Word
{
    private string _text { get; }
    public bool IsHidden { get; set; }

    public Word(string text)
    {
        _text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public void Show()
    {
        IsHidden = false;
    }

    public string GetDisplayText()
    {
        return IsHidden ? new string('_', _text.Length) : _text;
    }
}
