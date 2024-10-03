using System;
using System.Collections.Generic;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
       if (_verse == _endVerse)
        {
            // If the start and end verses are the same, just show the single verse
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            // If the start and end verses are different, show the range of verses
            return $"{_book} {_chapter}:{_verse} {_chapter}:{_endVerse}";
        }
    }
}