using System;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var count = Int32.Parse(input);

        for (int i = 0; i < count; i++)
        {
            for (int j = count - i;  1 < j; j--)
            {
                Console.Write(" ");
            }

            for (int k = 0; k <= i; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}