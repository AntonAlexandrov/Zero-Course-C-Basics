using System;
    class P3CheckaPlayCard
    {
        static void Main()
        {
            string[] card = "2,3,4,5,6,7,8,9,10,J,Q,K,A".Split(',');
            string a= Console.ReadLine();
            int n = 1;
            for (int i = 0; i <13; i++)
            {
                if (a == card[i])
                {
                    n += n;
                    Console.WriteLine("yes");
                }
            } 
            if (n == 1)
            {
                Console.WriteLine("no");

            }
        }
    }
