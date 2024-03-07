using System;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var count = Int32.Parse(input);

        for (int i = 1; i < count + 1; i++)
        {
            for (int j = count - i; 0 < j; j--)
            {
                Console.Write(" ");
            }

            for (int h = 1; h <= (2 * i) - 1; h++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}