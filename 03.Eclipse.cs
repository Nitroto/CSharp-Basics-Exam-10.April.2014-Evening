using System;

namespace Eclipse
{
    class Eclipse
    {
        static void Main()
        {
            int n = Int32.Parse(Console.ReadLine());
            int spaMid = 2 * n - 2;
            int line = 1;
            int halfN = n / 2 + 1;
            do
            {
                if (line == 1 || line == halfN || line == n)
                {
                    if (line == 1 || line == n)
                    {
                        Console.Write(' ');
                        Console.Write(new string('*', (2 * n-2)));
                        Console.Write(new string(' ', n+1));
                        Console.Write(new string('*', (2 * n-2)));
                        Console.WriteLine();
                        line++;
                    }
                    else
                    {
                        Console.Write("*");
                        Console.Write(new string('/', spaMid));
                        Console.Write("*");
                        Console.Write(new string('-', n-1));
                        Console.Write("*");
                        Console.Write(new string('/', spaMid));
                        Console.Write("*");
                        Console.WriteLine();
                        line++;
                    }
                }
                else
                {
                    Console.Write("*");
                    Console.Write(new string('/', spaMid));
                    Console.Write("*");
                    Console.Write(new string(' ', n-1));
                    Console.Write("*");
                    Console.Write(new string('/', spaMid));
                    Console.Write("*");
                    Console.WriteLine();
                    line++;
                }
            }
            while (line <= n);
        }
    }
}

