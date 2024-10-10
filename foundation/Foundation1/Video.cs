using System;
using System.Collections.Generic;

class Video
{
    private  string _title { get; set; }
    private string  _author { get; set; }
    private int _length { get; set; } // in seconds
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title
        _author = author
        _length = length
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment)
    }

    public int numberOfComments()
    {
        return _comments.Count;
    }

    public void displayComments()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        
        foreach (var comment in _comments)
        {
            Console.WriteLine($"{comment.commenterName}: {comment.Text}");
        }
    }





