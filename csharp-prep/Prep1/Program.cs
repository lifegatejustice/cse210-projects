using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is you firstname? ");
        string firstname = Console.ReadLine();

        Console.Write("What is you lastname? ");
        string lastname = Console.ReadLine();

        if (lastname.Length < 5 )
        {
            Console.WriteLine("Lastname is shorter than 5 characters.");
        }

        Console.WriteLine($"Your name is {lastname}, {firstname}, {lastname}");
  
    }
    

    
}