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
        } 
        while (input != 0);
        Console.WriteLine($"The sum is: {sum}");

        if (numbers.Count > 0)
        {
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");
            int maxNo = numbers[0];
            foreach (int num in numbers)
            {
                if (num > maxNo)
                {
                    maxNo = num;
                }
            }
            Console.WriteLine($"The maximum number is: {maxNo}");
        }
                    
        else
        {
            Console.WriteLine("No numbers entered.");
        }
        

        

        
    }
}