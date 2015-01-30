using System;

class CarNumbers
{
    static void Main()
    {
        int magicWeight = int.Parse(Console.ReadLine());

        magicWeight -= 40; //remove "CA" as it is the same every time

        int[] endLetters = { 10, 20, 30, 50, 80, 110, 130, 160, 200, 240 };

        int licenceCount = 0;
        int currentWeight;

        for(int lett1 = 0; lett1 < endLetters.Length; lett1++)
        {
            for(int lett2 = 0; lett2 < endLetters.Length; lett2++)
            {
                for(int n1 = 0; n1 < 10; n1++)
                {
                    for (int n2 = 0; n2 < 10; n2++)
                    {
                        for (int n3 = 0; n3 < 10; n3++)
                        {
                            for (int n4 = 0; n4 < 10; n4++)
                            {
                                currentWeight = endLetters[lett1] + endLetters[lett2] +
                                    n1 + n2 + n3 + n4;
                                if(currentWeight == magicWeight)
                                {
                                    if(n1 == n2 && n2 == n3 && n3 == n4)
                                    {
                                        licenceCount++;
                                    }
                                    if (n1 != n2 && n2 == n3 && n3 == n4)
                                    {
                                        licenceCount++;
                                    }
                                    if (n1 == n2 && n2 == n3 && n3 != n4)
                                    {
                                        licenceCount++;
                                    }
                                    if (n1 == n2 && n2 != n3 && n3 == n4)
                                    {
                                        licenceCount++;
                                    }
                                    if (n1 == n3 && n2 == n4 && n1 != n2)
                                    {
                                        licenceCount++;
                                    }
                                    if (n1 == n4 && n2 == n3 && n1 != n2)
                                    {
                                        licenceCount++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine(licenceCount);
    }
}