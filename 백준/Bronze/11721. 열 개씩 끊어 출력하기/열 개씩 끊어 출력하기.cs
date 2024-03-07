using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();

        StringBuilder sb = new StringBuilder();
        int index = 0;

        for (int i = 0; i < input.Length; i++)
        {
            index++;
            sb.Append(input[i]);

            if (index == 10)
            {
                Console.WriteLine(sb.ToString());
                index = 0;
                sb.Clear();
            }
        }

        Console.WriteLine(sb.ToString());
    }
}