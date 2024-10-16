using System;

class Program
{
    static void Main(string[] args)
    {
        //Create New Instance of the class
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}