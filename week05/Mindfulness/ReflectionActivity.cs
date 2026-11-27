
using System;

public class ReflectionActivity : Activity
{
    private string[] _prompts;
    private string[] _questions;
    private Random _random;

    public ReflectionActivity()
        : base(
            "Reflection Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
        )
    {
        _prompts = new string[]
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new string[]
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        _random = new Random();
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
        Console.WriteLine(
            "When you have something in mind, consider each of the following questions:"
        );

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            string question = _questions[_random.Next(_questions.Length)];

            Console.WriteLine();
            Console.WriteLine(question);

            int remainingSeconds =
                (int)Math.Ceiling((endTime - DateTime.Now).TotalSeconds);

            if (remainingSeconds > 0)
            {
                ShowSpinner(Math.Min(5, remainingSeconds));
            }
        }

        DisplayEndingMessage();
    }
}
