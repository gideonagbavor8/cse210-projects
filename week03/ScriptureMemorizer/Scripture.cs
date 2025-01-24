using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    public Reference Reference { get; }
    private List<Word> _words { get; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWord()
    {
        // Select one word that is not already hidden
        var wordToHide = _words.Where(static word => !word.IsHidden).OrderBy(_ => Guid.NewGuid()).FirstOrDefault();
        if (wordToHide != null)
        {
            wordToHide.Hide();
        }
    }

    public string GetDisplayText()
    {
        return string.Join(" ", _words.Select(word => word.GetDisplayText()));
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden);
    }
}
