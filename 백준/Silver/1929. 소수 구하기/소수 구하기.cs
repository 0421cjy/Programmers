using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();
        Int32.TryParse(input[0], out int start);
        Int32.TryParse(input[1], out int end);

        bool[] isPrime = Enumerable.Repeat(true, end + 1).ToArray();

        for (int i = 2; i * i <= end; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= end; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        StringBuilder sb = new StringBuilder();

        for (int i = Math.Max(2, start); i <= end; i++)
        {
            if (isPrime[i])
            {
                sb.AppendLine(i.ToString());
            }
        }

        Console.Write(sb.ToString());
    }
}