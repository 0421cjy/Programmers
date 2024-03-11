using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();
        var num = Int32.Parse(input[0]);
        var index = Int32.Parse(input[1]);

        foreach(var item in GetPrimeNumber(num).Select((x, i) => new { i, x }))
        {
            if (item.i + 1 == index)
            {
                Console.WriteLine(item.x);
                break;
            }
        }
    }

    static List<int> GetPrimeNumber(int n)
    {
        var list = new List<int>();
        var bools = Enumerable.Repeat(true, n + 1).ToArray();

        for (int i = 2; i <= n; i++)
        {
            if (bools[i])
            {
                for (int j = i; j <= n; j+= i)
                {
                    bools[j] = false;

                    if (list.Any(x => x == j) == false)
                    {
                        list.Add(j);
                    }
                }
            }
        }

        return list;
    }
}