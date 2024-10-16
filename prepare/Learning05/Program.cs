using System;

class Program
{
    static void Main(string[] args)
    {
        //Create New Instance of the class
        WritingAssignment writingAssignment = new WritingAssignment("Samuel Bennett", "Multiplication", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}