using System;
using System.Collections.Generic;

public class ScriptureMemorizer
{
    private List<Word> words;
    private Reference reference;

    public ScriptureMemorizer()
    {
        // Example scripture initialization
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world...");
        words = InitializeWords(scripture.Text);
        reference = new Reference(scripture.Reference);
    }

    private List<Word> InitializeWords(string text)
    {
        string[] wordArray = text.Split(' ');
        List<Word> wordList = new List<Word>();

        foreach (string word in wordArray)
        {
            wordList.Add(new Word(word));
        }

        return wordList;
    }

    public void Run()
    {
        DisplayScripture();

        while (!AllWordsHidden())
        {
            Console.WriteLine("Press Enter to hide words or type 'quit' to end.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            HideRandomWords();
            DisplayScripture();
        }
    }

    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine($"Scripture: {reference.GetFormattedReference()}");

        foreach (Word word in words)
        {
            if (word.IsHidden)
                Console.Write("____ ");
            else
                Console.Write($"{word.Value} ");
        }

        Console.WriteLine();
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = random.Next(1, words.Count / 2);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(words.Count);

            while (words[index].IsHidden)
                index = random.Next(words.Count);

            words[index].IsHidden = true;
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.IsHidden);
    }
}