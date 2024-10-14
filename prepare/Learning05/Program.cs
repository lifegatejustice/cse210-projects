using System;

class Program
{
    static void Main(string[] args)
    {
        //Create New Instance of the class
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());
    }
}