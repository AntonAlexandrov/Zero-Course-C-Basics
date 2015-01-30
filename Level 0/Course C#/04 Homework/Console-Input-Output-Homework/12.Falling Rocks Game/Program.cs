using System;
using System.Threading;

class FallingRocks
{

    static string rocks = "^@*&+%$#!.;"; //all the different rocks
    static char[,] screen = new char[5, 10]; //this is the screen
    static int dwarfX = 2;
    static int score = 0;
    static int lives = 3;

    static void FillScreen()
    {
        for (int y = 0; y < 10; y++)
        {
            for (int x = 0; x < 5; x++)
            {
               screen[x, y] = ' ';
            }
        }
        screen[dwarfX, 10 - 1] = '0';
    }

    static void MovePlayer()
    {
        ConsoleKey pressedKey = new ConsoleKey();
        pressedKey = Console.ReadKey(true).Key;

        if (pressedKey == ConsoleKey.RightArrow && dwarfX < 5 - 1)
        {
            screen[dwarfX + 1, 10 - 1] = '0'; //move zero to the right
            screen[dwarfX, 10 - 1] = ' '; //clear past zero
            dwarfX++;
        }
        if (pressedKey == ConsoleKey.LeftArrow && dwarfX > 0)
        {
            screen[dwarfX - 1, 10 - 1] = '0'; //move zero to the left
            screen[dwarfX, 10 - 1] = ' '; //clear past zero
            dwarfX--;
        }
    }
    static void GenerateRocks()
    {
        int chanceToPutRock = new Random().Next(0,11);
        int randomX = new Random().Next(0, 5);
        int randomRock = new Random().Next(0, rocks.Length);
        if (chanceToPutRock % 2 == 0)
        {
            screen[randomX, 0] = rocks[randomRock];
        }
        else
        {
            screen[randomX, 0] = ' ';
        }
    }

    static void MoveRocks()
    {
        score++; //increase the score every time the game is refreshed
        if(score % 50 == 0)
        {
            lives++;
        }
        for (int x = 0; x < 5; x++)       
        {
            for (int y = 9; y > 0; y--)
            {
                if (screen[x, y] != '0')        
                {
                    screen[x, y] = screen[x, y - 1];
                    screen[x, y - 1] = ' ';
                }
            }
        }
        if (screen[dwarfX, 8] != ' ')
        {
            lives--;
        }
    }
    static void DrawScreen()
    {
        Console.Clear();

        Console.WriteLine("THE GAME IS A LITTLE BIT BUGGY! \n");
        Console.WriteLine("Welcome to Falling Rocks!");
        Console.WriteLine("You lose if your lives get to 0!");
        Console.WriteLine("Your lives increase everytime the score goes up by 50!");
        Console.WriteLine("Score: {0} Lives: {1}", score, lives);

        for(int y = 0; y < 10; y++)
        {
            for(int x = 0; x < 5; x++)
            {
                Console.Write(screen[x,y]);
            }
            Console.WriteLine(); //start drawing from next line
        }
        Console.WriteLine();
    }
    static void Main()
    {
        FillScreen();
        while (true)
        {
            while (!Console.KeyAvailable)
            {
                if (lives == 0)
                {
                    break;
                }
                Thread.Sleep(200);
                MoveRocks();
                DrawScreen();
                GenerateRocks();            
            }
            if (lives == 0)
            {
                break;
            }
            MovePlayer();               
        }
        Console.Clear();
        Console.WriteLine("Game Over! Your Score is: {0}", score);
    }
        
}