using System;

class Sunglasses
{
    static void Main()
    {
        int n = byte.Parse(Console.ReadLine());

        int height = n;
        int lenght = n * 2;
        int bridgeLenght = n;
        int glassesLenght = lenght * 2 + bridgeLenght;

        for (int i = 0; i < height; i++)
        {
            for(int j = 0; j < glassesLenght; j++)
            {
                if ( i == 0 || i == n-1)
                {
                    if((j >= 0 && j < lenght) || (j >= lenght + bridgeLenght && j < glassesLenght) )
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                else
                {
                    if(j == 0 || j == lenght - 1 || j == lenght + bridgeLenght || j == glassesLenght - 1)
                    {
                        Console.Write('*');
                    }
                    else if((j > 0 && j < lenght - 1) || (j > lenght + bridgeLenght && j < glassesLenght - 1))
                    {
                        Console.Write('/');
                    }
                    else if(j >= lenght && j <= lenght + bridgeLenght - 1)
                    {
                        if(i != n / 2)
                        {
                            Console.Write(' ');
                        }
                        else
                        {
                            Console.Write('|');
                        }
                        
                    }                    
                }
            }
            Console.WriteLine();
            
        }

    }
}