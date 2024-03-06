using System;

class Program
{
    static void Main(string[] args)
    {
        var input1 = Console.ReadLine();
        var input2 = Console.ReadLine();

        var num1 = Int32.Parse(input1);
        var num2 = Int32.Parse(input2);

        Console.WriteLine(num1 + num2);
    }
}