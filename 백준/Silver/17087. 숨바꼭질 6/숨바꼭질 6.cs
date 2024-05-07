using System;
using System.Collections.Generic;
using System.Linq;

public partial class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();
        var count = Int32.Parse(input[0]);
        var num = Int32.Parse(input[1]);

        var list = new List<int>();

        var nums = Console.ReadLine().Split();
        foreach (var i in nums ) 
        {
            list.Add(Int32.Parse(i));
        }

        list = list.Select(x => Math.Abs(x - num)).ToList();

        Console.WriteLine(list.Aggregate(gcd));
    }

    static int gcd(int n, int m)
    {
        while (m > 0)
        {
            var r = n % m;
            n = m;
            m = r;
        }

        return n;
    }
}