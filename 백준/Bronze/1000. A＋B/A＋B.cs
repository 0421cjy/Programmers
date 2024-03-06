using System;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();
        var num1 = Int32.Parse(input[0]);
        var num2 = Int32.Parse(input[1]);

        Console.WriteLine(num1 + num2);
    }
}