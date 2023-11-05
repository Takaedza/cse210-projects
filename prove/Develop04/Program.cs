using System;
using System.Diagnostics;

class Program
{

    static void Main(string[] args)
    {
        // This will clear the console
        Console.Clear();
        Console.Write("\n*** Welcome to the Mindfulness Program ****\n");
        //Call Choices
        Choices choice = new Choices();
        int seconds;

        int action = 0;
        while (action != 4)
        {
            // Ask for user input (1-4)
            action = choice.userChoices();
            switch (action)
            {
                case 1:
                    // Start Breathing Activity
                    Console.Clear();
                    BreathingTasks breathing = new BreathingTasks("Breathing Activity", 0);
                    breathing.GetTasksName();
                    breathing.GetTasksDescription();
                    seconds = breathing.GetTasksTime();
                    //breathing.GetReadyToStart();
                    breathing.Breathing(seconds);
                    breathing.GetDone();
                    break;
                case 2:
                    //Start Reflecting Activity
                    Console.Clear();
                    ReflectingTasks reflecting = new ReflectingTasks("Reflecting Activity", 0);
                    reflecting.GetTasksName();
                    reflecting.GetTasksDescription();
                    seconds = reflecting.GetTasksTime();
                    //reflecting.GetReadyToStart();
                    reflecting.ShowPrompt(seconds);
                    reflecting.GetDone();
                    break;
                case 3:
                    //Start Listing Activity
                    Console.Clear();
                    ListingTasks listing = new ListingTasks("Listing Activity", 0);
                    listing.GetTasksName();
                    listing.GetTasksDescription();
                    seconds = listing.GetTasksTime();
                    //listing.GetReadyToStart();
                    listing.ReturnPrompt(seconds);
                    listing.GetDone();
                    break;
                case 4:
                    // Quite
                    Console.WriteLine("\nThank you for using the Mindfulness Program!\n");
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }
    class Choices
    {
        public int userChoices()
        {
            Console.WriteLine("\nPlease choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }


    }


}