using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            var input = Console.ReadLine();
            if (input == "0")
            {
                break;
            }

            var n = Int32.Parse(input);
            Console.WriteLine(PrimeGenerator(n + 1, n * 2).Count());
        }
    }

    static IEnumerable<int> PrimeGenerator(int start, int end)
    {
        for (int i = Math.Max(2, start); i <= end; i++)
        {
            if (IsPrime(i))
            {
                yield return i;
            }
        }
    }

    static bool IsPrime(int n)
    {
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}