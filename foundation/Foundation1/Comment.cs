using System;
using System.Collections.Generic;

class Comment
{
    private string _text;
    private string _commenterName; 

    
    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

    
    public string CommenterName
    {
        get { return _commenterName; }
    }

    public string Text
    {
        get { return _text; }
    }
}
