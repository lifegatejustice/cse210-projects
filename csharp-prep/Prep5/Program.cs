using System;

class Program
{
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program! ");
    }
    static void Main(string[] args)
    {
        DisplayMessage();

        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        Console.Write("Enter your favourite number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        SquareRoot(number, userName);
    }


    static void SquareRoot(int number, string userName)
    {
        double squareRoot = Math.Sqrt(number);
        Console.WriteLine($"{userName}, the square root of {number} is {squareRoot}");
    }
}
