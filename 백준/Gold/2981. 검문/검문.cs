using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var count = Int32.Parse(input);

        List<int> list = new List<int>();

        for (int i = 0; i < count; i++)
        {
            var num = Int32.Parse(Console.ReadLine());

            list.Add(num);
        }

        list.Sort();

        var newList = new List<int>();
        for (int i = 0; i < list.Count - 1;i++)
        {
            newList.Add(list[i + 1] - list[i]);
        }

        var result = newList.Aggregate(gcd);

        foreach (int i in divisor(result))
        {
            Console.Write($"{i} ");
        }
    }

    static int gcd(int n, int m)
    {
        return (0 < m) ? gcd(m, n % m) : n;
    }

    static IEnumerable<int> divisor(int n)
    {
        for (int i = 2; i <= n; i++)
        {
            if (n % i == 0)
            {
                yield return i;
            }
        }
    }
}