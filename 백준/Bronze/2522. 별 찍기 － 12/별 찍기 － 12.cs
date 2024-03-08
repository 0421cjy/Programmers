using System;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var count = Int32.Parse(input);

        for (int i = 0; i < count; i++)
        {
            for (int j = count - i; 1 < j; j--)
            {
                Console.Write(" ");
            }

            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        for (int i = 1; i < count; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(" ");
            }

            for (int j = count - i; 0 < j; j--)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}