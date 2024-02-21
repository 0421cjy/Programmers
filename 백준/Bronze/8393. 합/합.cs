using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        Int32.TryParse(input, out int value);

        int r = 0;

        for (int i = 1; i <= value; i++)
        {
            r += i;
        }

        Console.WriteLine(r);
    }
}