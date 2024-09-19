using System;

class Program
{
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static void DisplayPersonalMessage(string userName)
    {
        Console.WriteLine($"Hello, {userName}! Welcome to the program.");
    }

    static void Main(string[] args)
    {
        // Call the DisplayMessage method
        DisplayMessage();

        // Ask for the user's name
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        
        // Call the DisplayPersonalMessage method with the user's name
        DisplayPersonalMessage(userName);

        // Ask for a number to calculate the square root
        Console.Write("Enter your favourite number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        SquareRoot(number, userName); 

    static void SquareRoot(int number, string userName)
    {
        double squareRoot = Math.Sqrt(number);
        Console.WriteLine($"{userName}, the square root of {number} is {squareRoot}");
    }
}
