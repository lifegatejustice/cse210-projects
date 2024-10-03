using System;
using System.Collections.Generic
public class Scripture
{
    private Reference _refrence;
    public List<Word> _words;

    public Scripture(Reference _reference, string text)
    {
        _refrence = _reference;
        _words = new List<Word>();

        string[] wordsArray = text.Split(' ');
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }


    }

}