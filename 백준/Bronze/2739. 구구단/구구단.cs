using System;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var num = Int32.Parse(input);

        for (int i = 1; i < 10; i++) 
        {
            Console.WriteLine($"{num} * {i} = {num * i}");
        }
    }
}