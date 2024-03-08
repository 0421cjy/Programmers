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
            for (int j = count - i; 1 < j; j--)
            {
                sb.Append(" ");
            }

            for (int j = 0; j < Math.Max((2 * i) + 1, 1); j++)
            {
                if (j % 2 == 0)
                {
                    sb.Append("*");
                }
                else
                {
                    sb.Append(" ");
                }
            }

            sb.AppendLine();
        }

        Console.WriteLine(sb.ToString());
    }
}