using System;

class PrintStringsObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";

        object objSentence = hello + ' ' + world;

        string strSentence = (string)objSentence;

        Console.WriteLine(objSentence);
        Console.WriteLine(strSentence);
    }
}