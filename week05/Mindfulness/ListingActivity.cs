
using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private string[] _prompts;
    private Random _random;
    private int _itemCount;

    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
        )
    {
        _prompts = new string[]
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _random = new Random();
        _itemCount = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        string prompt = _prompts[_random.Next(_prompts.Length)];

        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.WriteLine();
        Console.WriteLine("Start listing your responses below.");
        Console.WriteLine("Press ENTER after each item.");

        List<string> responses = new List<string>();
        _itemCount = 0;

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");

            string response = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);
                _itemCount = responses.Count;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {_itemCount} items!");

        DisplayEndingMessage();
    }

    public int GetItemCount()
    {
        return _itemCount;
    }
}
