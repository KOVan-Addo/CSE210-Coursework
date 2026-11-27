
using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        // CREATIVITY ENHANCEMENT:
        // The Mindfulness Session Journal records every completed activity,
        // its selected duration, and the number of items entered during
        // Listing Activities. It also calculates the total recorded
        // mindfulness duration and displays a session summary when the
        // user exits the program.

        List<string> sessionJournal = new List<string>();

        int totalDuration = 0;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("==================================");
            Console.WriteLine("   MINDFULNESS PROGRAM");
            Console.WriteLine("==================================");
            Console.WriteLine();
            Console.WriteLine("Please select an activity:");
            Console.WriteLine();
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();

            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing =
                        new BreathingActivity();

                    breathing.Run();

                    sessionJournal.Add(
                        $"{breathing.GetName()} - {breathing.GetDuration()} seconds"
                    );

                    totalDuration += breathing.GetDuration();

                    break;

                case "2":
                    ReflectionActivity reflection =
                        new ReflectionActivity();

                    reflection.Run();

                    sessionJournal.Add(
                        $"{reflection.GetName()} - {reflection.GetDuration()} seconds"
                    );

                    totalDuration += reflection.GetDuration();

                    break;

                case "3":
                    ListingActivity listing =
                        new ListingActivity();

                    listing.Run();

                    sessionJournal.Add(
                        $"{listing.GetName()} - {listing.GetDuration()} seconds - {listing.GetItemCount()} items listed"
                    );

                    totalDuration += listing.GetDuration();

                    break;

                case "4":
                    running = false;

                    Console.Clear();

                    Console.WriteLine("Thank you for using the Mindfulness Program!");

                    DisplaySessionJournal(
                        sessionJournal,
                        totalDuration
                    );

                    Console.WriteLine();
                    Console.WriteLine("Goodbye!");

                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine(
                        "Invalid choice. Please select 1, 2, 3, or 4."
                    );

                    Thread.Sleep(2000);

                    break;
            }
        }
    }

    public static void DisplaySessionJournal(
        List<string> sessionJournal,
        int totalDuration
    )
    {
        Console.WriteLine();
        Console.WriteLine("==================================");
        Console.WriteLine("   MINDFULNESS SESSION JOURNAL");
        Console.WriteLine("==================================");
        Console.WriteLine();

        if (sessionJournal.Count == 0)
        {
            Console.WriteLine("No activities were completed during this session.");
        }
        else
        {
            Console.WriteLine("Your completed activities:");
            Console.WriteLine();

            for (int i = 0; i < sessionJournal.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {sessionJournal[i]}");
            }
        }

        Console.WriteLine();
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Activities completed: {sessionJournal.Count}");
        Console.WriteLine($"Total recorded mindfulness time: {totalDuration} seconds");
        Console.WriteLine("----------------------------------");
    }
}
