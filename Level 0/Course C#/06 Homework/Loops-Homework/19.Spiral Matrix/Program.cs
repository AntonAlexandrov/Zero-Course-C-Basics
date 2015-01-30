using System;

class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        char direction = 'r'; //right, down, left, up

        int minX = 0;
        int maxX = n - 1;
        int minY = 1;
        int maxY = n - 1;

        int curX = 0, curY = 0;

        for(int i = 0; i < n*n; i++)
        {
            matrix[curY, curX] = i + 1;

            if (direction == 'r' && curX == maxX)
            {
                direction = 'd';
                maxX--;
            }
            else if (direction == 'd' && curY == maxY)
            {
                direction = 'l';
                maxY--;
            }
            else if (direction == 'l' && curX == minX)
            {
                direction = 'u';
                minX++;
            }
            else if (direction == 'u' && curY == minY)
            {
                direction = 'r';
                minY++;
            }

            switch(direction)
            {
                case 'r': curX++; break;
                case 'd': curY++; break;
                case 'l': curX--; break;
                case 'u': curY--; break;
            }
        }

        for(int row = 0; row < n; row++)
        {
            for(int col = 0; col < n; col++)
            {
                Console.Write(matrix[row, col].ToString().PadRight(4, ' '));
            }
            Console.WriteLine();
        }
    }
}