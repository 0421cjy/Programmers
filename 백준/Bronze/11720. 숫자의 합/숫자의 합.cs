using System;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var count = Int32.Parse(input);

        var input2 = Console.ReadLine();
        var sum = 0;

        for (int i = 0; i < count; i++)
        {
            sum += input2[i] - '0';
        }

        Console.WriteLine(sum);
    }
}