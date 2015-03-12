using System;

namespace OddEvenSum
{
    class OddEvenSum
    {
        static void Main()
        {
            ushort n = ushort.Parse(Console.ReadLine());
            long sumOdd = 0;
            long sumEven = 0;
            for (int i = 1; i <= (2 * n); i++)
            {
                int num = Int32.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += num;
                }
                else
                {
                    sumOdd += num;
                }
            }
            if (sumOdd == sumEven)
            {
                Console.WriteLine("Yes, sum={0}", sumOdd);
            }
            else
            {
                Console.WriteLine("No, diff={0}", Math.Abs(sumOdd - sumEven));
            }
        }
    }
}
