using System;

using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        _prompts.Add("Who was the most interesting person i interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did i see the hand of the lord in my life today?");
        _prompts.Add("What was the strongest emotion i felt today?");
        _prompts.Add("If i had one thing i could do over today what would it be?");
        _prompts.Add("What is something new you learned today?");
        _prompts.Add("Describe a memorable moment from your day.");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}
