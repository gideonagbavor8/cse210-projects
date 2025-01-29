using System;

class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;

    public Reference(string book, int chapter, int verse, int? endVerse = null)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetBook()
    {
        return _book;
    }

    public int GetChapter()
    {
        return _chapter;
    }

    public int GetVerse()
    {
        return _verse;
    }

    public int? GetEndVerse()
    {
        return _endVerse;
    }

    public string GetDisplayText()
    {
        return _endVerse.HasValue ? $"{_book} {_chapter}:{_verse}-{_endVerse}" : $"{_book} {_chapter}:{_verse}";
    }
}


























// using System;

// class Reference
// {
//     private string _book { get; }
//     private int _chapter { get; }
//     private int _verse { get; }
//     private int? _endVerse { get; }

//     public Reference(string book, int chapter, int verse, int? endVerse = null)
//     {
//         _book = book;
//         _chapter = chapter;
//         _verse = verse;
//         _endVerse = endVerse;
//     }

//     public string GetDisplayText()
//     {
//         return _endVerse.HasValue ? $"{_book} {_chapter}:{_verse}-{_endVerse}" : $"{_book} {_chapter}:{_verse}";
//     }
// }
