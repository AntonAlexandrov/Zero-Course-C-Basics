using System;

class Letters
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        int[] nums = { 5, -12, 47, 7, -32 };
        char[] symbs = { 'a', 'b', 'c', 'd', 'e' };

        int weight;
        int multiplier;
        bool possible = false;

        for(int n0 = 0; n0 < 5; n0++)
        {
            for (int n1 = 0; n1 < 5; n1++)
            {
                for (int n2 = 0; n2 < 5; n2++)
                {
                    for (int n3 = 0; n3 < 5; n3++)
                    {
                        for (int n4 = 0; n4 < 5; n4++)
                        {
                            weight = 0;
                            multiplier = 1;
                            weight += multiplier * nums[n0];
                            if(n1 != n0)
                            {
                                multiplier++;
                                weight += multiplier * nums[n1];
                            }
                            if (n2 != n1 && n2 != n0)
                            {
                                multiplier++;
                                weight += multiplier * nums[n2];
                            }
                            if (n3 != n2 && n3 != n1 && n3 != n0)
                            {
                                multiplier++;
                                weight += multiplier * nums[n3];
                            }
                            if (n4 != n3 && n4 != n2 && n4 != n1 && n4 != n0)
                            {
                                multiplier++;
                                weight += multiplier * nums[n4];
                            }

                            if(weight >= start && weight <= end)
                            {
                                possible = true;
                                Console.Write("{0}{1}{2}{3}{4} ",
                                    symbs[n0], symbs[n1], symbs[n2], symbs[n3], symbs[n4]);
                            }
                        }
                    }
                }
            }
        }

        if (!possible)
        {
            Console.WriteLine("No");
        }
    }
}