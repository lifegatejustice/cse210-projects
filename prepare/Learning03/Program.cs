using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        f1.Display();

        Fraction f2 = new Fraction(5);
        f1.Display();

        Fraction f3 = new Fraction(3,4);
        f1.Display();
    }
}