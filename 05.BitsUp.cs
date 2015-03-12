using System;

namespace BitsUp
{
    class BitsUp
    {
        static void Main()
        {
            int n = Int32.Parse(Console.ReadLine());
            int step = Int32.Parse(Console.ReadLine());
            int counter = 0;
            int[] transformedNums = new int[n];
            for (int i = 0; i < n; i++)
            {
                int num = Int32.Parse(Console.ReadLine());
                for (int j = 7; j >= 0; j--)
                {
                    if ((counter % step == 1) || (step == 1 && counter > 0))
                    {
                        num = num | (1 << j);
                    }
                    counter++;
                }
                transformedNums[i] = num;
            }
            foreach (int element in transformedNums)
            {
                Console.WriteLine(element);
            }
        }
    }
}
