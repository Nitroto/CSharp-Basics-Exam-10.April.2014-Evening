using System;

namespace HayvanNumbers
{
    class HayvanNumbers
    {
        private static int SumOfDigits(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
        private static bool NumberChecker(int n)
        {
            string number = n.ToString();
            foreach (var digit in number)
            {
                if (digit < '5' || digit > '9')
                {
                    return false;
                }
            }
            return true;
        }
        static void Main()
        {
            int sum = Int32.Parse(Console.ReadLine());
            int diff = Int32.Parse(Console.ReadLine());
            int counter = 0;
            for (int a = 5; a <= 9; a++)
            {
                for (int b = 5; b <= 9; b++)
                {
                    for (int c = 5; c <= 9; c++)
                    {
                        int abc = a * 100 + b * 10 + c;
                        int def = abc + diff;
                        int ghi = def + diff;
                        if (NumberChecker(abc) && NumberChecker(def) && NumberChecker(ghi))
                        {
                            int sumForCheck = SumOfDigits(abc) + SumOfDigits(def) + SumOfDigits(ghi);
                            if (sumForCheck == sum)
                            {
                                Console.WriteLine("" + abc + def + ghi);
                                counter++;
                            }
                        }
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
