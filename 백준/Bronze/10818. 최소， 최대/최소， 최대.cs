using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var r = Console.ReadLine().Split().Select(Int32.Parse).ToArray();

        Console.WriteLine($"{r.Min()} {r.Max()}");
    }
}