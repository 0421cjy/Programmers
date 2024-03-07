using System;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var count = Int32.Parse(input);

        for (int i = 0; i < count; i++)
        {
            for (int j = 0;  j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}