using System;

class Program
{
    static void DisplayMessage()
    {
        Console.Write("Welcome to the Program!");
    }

    static void DisplayPersonalMessage(string userName)
    {
        Console.Write($"Please enter your name: {userName}");
    }

    static void Main(string[] args)
        {
            DisplayMessage();
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            DisplayPersonalMessage(userName);
            
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            squareRoot(number);
        }

    static void squareRoot(int first)
    {
        double squareRoot = Math.Sqrt(first);
        Console.WriteLine("The square root of " + first + " is " + squareRoot);
    }
}