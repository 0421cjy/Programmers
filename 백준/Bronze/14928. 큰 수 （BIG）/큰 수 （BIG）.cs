using System;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();

        int value = 0;

        for (int i = 0; i < input.Length; i++)
        {
            value = (value * 10 + (input[i] - '0')) % 20000303;
        }

        Console.WriteLine(value);
    }
}