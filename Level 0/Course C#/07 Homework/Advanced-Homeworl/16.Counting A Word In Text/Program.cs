using System;

class WordCounter
{
    static void Main()
    {
        //not finished
        string word = Console.ReadLine().ToLower();
        string text = Console.ReadLine().ToLower();

        string[] words = text.Split(' ');

        int wordCount = 0;
        
        for(int i = 0; i < words.Length; i++)
        {
            if(words[i].Contains(word))
            {
                wordCount++;
            }
        }

        Console.WriteLine(wordCount);
    }
}