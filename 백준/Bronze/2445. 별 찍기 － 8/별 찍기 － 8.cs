using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var count = Int32.Parse(input);

        var sb = new StringBuilder();

        for (int i = 0; i < count; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                sb.Append("*");
            }

            for (int j = count - i; 1 < j; j--)
            {
                sb.Append(" ");
            }

            for (int j = count - i; 1 < j; j--)
            {
                sb.Append(" ");
            }

            for (int j = 0; j < i + 1; j++)
            {
                sb.Append("*");
            }

            sb.AppendLine();
        }

        for (int i = 1; i < count; i++)
        {
            for (int j = count - i; 0 < j; j--)
            {
                sb.Append("*");
            }

            for (int j = 0; j < i; j++)
            {
                sb.Append(" ");
            }

            for (int j = 0; j < i; j++)
            {
                sb.Append(" ");
            }

            for (int j = count - i; 0 < j; j--)
            {
                sb.Append("*");
            }

            sb.AppendLine();
        }

        Console.WriteLine(sb.ToString());
    }
}