using System;

class Program
{
    static void Main(string[] args)
    {
        //Create New Instance of the class
        MathAssignment mathAssignment = new MathAssignment("Samuel Bennett", "Multiplication", "Section 7.3", "Problems 8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
    }
}