using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();
        var num1 = BigInteger.Parse(input[0]);
        var num2 = BigInteger.Parse(input[1]);

        Console.WriteLine(num1 * num2);
    }
}