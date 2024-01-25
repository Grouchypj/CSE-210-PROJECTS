using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create an instance of the ScriptureMemorizer class
        ScriptureMemorizer memorizer = new ScriptureMemorizer();

        // Display the scripture initially
        memorizer.DisplayScripture();

        // Continue hiding words until all words are hidden or user types "quit"
        while (!memorizer.AllWordsHidden())
        {
            Console.WriteLine("Press Enter to hide words or type 'quit' to end.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            memorizer.HideRandomWords();
            memorizer.DisplayScripture();
        }
    }
}

class ScriptureMemorizer
{
    private List<string> words;
    private List<int> hiddenIndices;

    public ScriptureMemorizer()
    {
        // Initialize your scripture text and reference here
        words = new List<string> { "For", "God", "so", "loved", "the", "world", "that", "He", "gave", "His", "only", "begotten", "Son" };
        hiddenIndices = new List<int>();
    }

    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine("Scripture: John 3:16");
        
        for (int i = 0; i < words.Count; i++)
        {
            if (hiddenIndices.Contains(i))
                Console.Write("____ ");
            else
                Console.Write(words[i] + " ");
        }
        
        Console.WriteLine();
    }

    public void HideRandomWords()
    {
        // Randomly select words to hide
        Random random = new Random();
        int wordsToHide = random.Next(1, words.Count / 2);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(words.Count);
            
            // Ensure the word is not already hidden
            while (hiddenIndices.Contains(index))
                index = random.Next(words.Count);

            hiddenIndices.Add(index);
        }
    }

    public bool AllWordsHidden()
    {
        return hiddenIndices.Count == words.Count;
    }
}
