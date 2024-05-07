using System;
using System.Collections.Generic;
using System.Linq;

public partial class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();
        var num = Int32.Parse(input[1]);

        var list = new List<int>();

        var nums = Console.ReadLine().Split();
        foreach (var i in nums) 
        {
            var n = Int32.Parse(i);
            list.Add(Math.Abs(n - num));
        }

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