using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var count = Int32.Parse(input);

        var input2 = Console.ReadLine().Split();
        var list = new List<int>();

        for (int i = 0; i < count; i++)
        {
            list.Add(Int32.Parse(input2[i]));
        }

        Console.WriteLine($"{list.Min()} {list.Max()}");
    }
}