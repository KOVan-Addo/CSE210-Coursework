
using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "What challenged you today, and how did you respond?",
        "What are you grateful for today?",
        "What did you learn today?",
        "Who made a positive difference in your life today?",
        "What is something you could have done better today?",
        "What is one goal you want to accomplish tomorrow?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();

        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}
