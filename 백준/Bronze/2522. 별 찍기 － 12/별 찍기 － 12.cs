using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        using var writer = new StreamWriter(Console.OpenStandardOutput());
        using var reader = new StreamReader(Console.OpenStandardInput());

        var input = reader.ReadLine();
        var count = Int32.Parse(input);

        for (int i = 0; i < count; i++)
        {
            for (int j = count - i; 1 < j; j--)
            {
                writer.Write(" ");
            }

            for (int j = 0; j <= i; j++)
            {
                writer.Write("*");
            }

            writer.WriteLine();
        }

        for (int i = 1; i < count; i++)
        {
            for (int j = 0; j < i; j++)
            {
                writer.Write(" ");
            }

            for (int j = count - i; 0 < j; j--)
            {
                writer.Write("*");
            }

            writer.WriteLine();
        }
    }
}