using System;

class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char[] line = new char[n];
        int lineIndex = 0;
        int astIndex1 = n / 2;
        int astIndex2 = n / 2;

       while(lineIndex < n / 2)//prints the first half of the diamond
       {
           for(int i = 0; i < n; i++)
           {
                if(i == astIndex1 || i == astIndex2)
                {
                    line[i] = '*';
                }
               else
                {
                    line[i] = '-';
                }
           }
           astIndex1--;
           astIndex2++;
           lineIndex++;
           for(int j = 0; j < n; j++)
           {
               Console.Write(line[j]);
           }
           Console.Write("\r\n");
       }
       while (lineIndex >= n / 2 && lineIndex < n)//prints the second half of the diamond
       {
           for (int i = 0; i < n; i++)
           {
               if (i == astIndex1 || i == astIndex2)
               {
                   line[i] = '*';
               }
               else
               {
                   line[i] = '-';
               }
           }
           astIndex1++;
           astIndex2--;
           lineIndex++;
           for (int j = 0; j < n; j++)
           {
               Console.Write(line[j]);
           }
           Console.Write("\r\n");
       }
    }
}