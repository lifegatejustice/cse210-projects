using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int sum = 0;

        Console.Write("Enter a list of numbers, type 0 when finished.");
        // string userList = Console.ReadLine();
        // int input = int.Parse(userList);

        int input;

        do
        {
            Console.Write("Enter number: ");
            string userList = Console.ReadLine();
            input = int.Parse(userList);

            if (input != 0)
            {
                numbers.Add(input);
                sum += input;
            }
        } while (input != 0);
        {

        }

        
    }
}