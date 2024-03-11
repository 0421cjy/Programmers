using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var count = Int32.Parse(input);

        for (int i = 0; i < count; i++) 
        {
            var num_input = Console.ReadLine();
            var num = Int32.Parse(num_input);

            var list = GetPrimeNumber(num);

            var temp = GetGoldBagh(list, num);
            Console.WriteLine(temp.Item1 < temp.Item2 ? $"{temp.Item1} {temp.Item2}" : $"{temp.Item2} {temp.Item1}");
        }
    }

    static (int, int) GetGoldBagh(List<int> list, int num)
    {
        for (int j = list.Count() - 1; 0 <= j; j--)
        {
            if (num / 2 < list[j]) continue;

            for (int k = list.Count() - 1; 0 <= k; k--)
            {
                if (list[j] + list[k] == num)
                {
                    return (list[j], list[k]);
                }
            }
        }

        return (0, 0);
    }

    static List<int> GetPrimeNumber(int n)
    {
        var isPrime = Enumerable.Repeat(true, n + 1).ToArray();

        for (int i = 2; i * i <= n; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= n; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        List<int> ints = new List<int>();

        for (int i = 2; i <= n; i++)
        {
            if (isPrime[i])
            {
                ints.Add(i);
            }
        }

        return ints;
    }
}