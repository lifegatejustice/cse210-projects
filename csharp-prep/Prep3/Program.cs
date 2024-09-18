using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string magicNumber = Console.ReadLine();
        int magic = int.Parse(magicNumber);

        do
        {
            Console.Write("What is your guess? ");
            string guessNumber = Console.ReadLine();
            int guess = int.Parse(guessNumber);

            if (guess > magic)
            {
                Console.WriteLine("Lower");
            }

            else if (guess < magic)
            {
                Console.WriteLine("Higher");
            }
        } 
        while (guess != magic);
        Console.WriteLine("You guessed it!");
    }
}