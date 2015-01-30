using System;

class ZeroSubset
{
    static void Main()
    {
        /*The program repeats many subsets but works correctly*/
        bool possibleSubset = false;
        char[] splitChar = {' '};
        string[] inputNumbers = Console.ReadLine().Split(splitChar);

        double[] numbers = new double[inputNumbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = double.Parse(inputNumbers[i]);
        }

        for (int n1 = 0; n1 < numbers.Length; n1++)
        {
            if(numbers[n1] == 0)
            {
                Console.WriteLine("{0} = 0", numbers[n1]);
                possibleSubset = true;
            }
            for (int n2 = 1; n2 < numbers.Length; n2++)
            {
                if(numbers[n1] + numbers[n2] == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", numbers[n1], numbers[n2]);
                    possibleSubset = true;
                }
                for (int n3 = 2; n3 < numbers.Length; n3++)
                {
                    if (numbers[n1] + numbers[n2] + numbers[n3] == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} = 0", numbers[n1], numbers[n2], numbers[n3]);
                        possibleSubset = true;
                    }
                    for (int n4 = 3; n4 < numbers.Length; n4++)
                    {
                        if (numbers[n1] + numbers[n2] + numbers[n3] + numbers[n4] == 0)
                        {
                            Console.WriteLine("{0} + {1} + {2} + {3} = 0", numbers[n1], numbers[n2], numbers[n3], numbers[n4]);
                            possibleSubset = true;
                        }
                        for (int n5 = 4; n5 < numbers.Length; n5++)
                        {
                            if (numbers[n1] + numbers[n2] + numbers[n3] + numbers[n4] + numbers[n5] == 0)
                            {
                                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", numbers[n1], numbers[n2], numbers[n3], numbers[n4], numbers[n5]);
                                possibleSubset = true;
                            }
                        }
                    }
                }
            }
        }

        if(!possibleSubset)
        {
            Console.WriteLine("no zero subset");
        }

    }
}