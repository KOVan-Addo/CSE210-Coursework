
using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the scripture text into individual words
        string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // Create a Word object for each word
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    // Hide a specified number of random visible words
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        // Store the positions of words that are not yet hidden
        List<int> visibleIndexes = new List<int>();

        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleIndexes.Add(i);
            }
        }

        // Hide words without selecting an already hidden word
        int wordsToHide = Math.Min(numberToHide, visibleIndexes.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int randomPosition = random.Next(visibleIndexes.Count);
            int wordIndex = visibleIndexes[randomPosition];

            _words[wordIndex].Hide();

            visibleIndexes.RemoveAt(randomPosition);
        }
    }

    // Return the scripture reference and text for display
    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();

        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }

        string scriptureText = string.Join(" ", displayWords);

        return $"{_reference.GetDisplayText()}\n{scriptureText}";
    }

    // Check whether every word has been hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}
