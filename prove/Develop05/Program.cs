using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            // Display menu options to the user
            Console.WriteLine("\n--- Choose an Activity ---");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            Activity selectedActivity = null;

            switch (choice)
            {
                case "1":
                    selectedActivity = new BreathingActivity();
                    break;
                case "2":
                    selectedActivity = new ReflectingActivity();
                    break;
                case "3":
                    selectedActivity = new ListingActivity();
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    continue;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid activity.");
                    continue;
            }

            // Display the starting message
            selectedActivity.DisplayStartingMessage();

            // Ask user for the duration of the activity
            Console.WriteLine("how long should the session last in in seconds:");
            int duration;
            while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
            {
                Console.WriteLine("Please enter a valid number for the duration:");
            }

            selectedActivity.SetDuration(duration);
            
            // Run the selected activity
            selectedActivity.ShowCountDown(3);
            
            if (selectedActivity is BreathingActivity)
            {
                ((BreathingActivity)selectedActivity).Run();
            }
            else if (selectedActivity is ListingActivity)
            {
                ((ListingActivity)selectedActivity).Run();
            }
            else if (selectedActivity is ReflectingActivity)
            {
                ((ReflectingActivity)selectedActivity).Run();
            }

            selectedActivity.DisplayEndingMessage();
        }
    }
}
