using System;

class ExtractURLs
{
    static void Main()
    {
        //doesn't work fully
        string inputStr = Console.ReadLine();
        string[] words = inputStr.Split(' ');

        for(int i = 0; i < words.Length; i++)
        {
            if(words[i].StartsWith("http://") || words[i].StartsWith("www."))
            {
                Console.WriteLine(words[i]);                
            }
        }
    }
}