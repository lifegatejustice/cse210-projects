using System;
using System.Collections;

public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
<<<<<<< HEAD
=======
        
    }



>>>>>>> a58194f202e692869362f180d46c049cd24771e0
}