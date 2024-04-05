using System;
using System.Text;

public partial class Program
{
    static void Main(string[] args)
    {
        var sb = new StringBuilder();

        var input = Console.ReadLine();
        var count = Int32.Parse(input);

        for (int i = 0; i < count; i++) 
        {
            var str = Console.ReadLine();

            var count1 = 0;

            for (int j = 0; j < str.Length; j++)
            {
                if (str[j] == '(')
                {
                    count1 += 1;
                }
                else if (str[j] == ')')
                {
                    count1 -= 1;
                }

                if (count1 < 0) break;
            }

            if (count1 == 0)
            {
                sb.AppendLine("YES");
            }
            else
            {
                sb.AppendLine("NO");
            }
        }

        Console.WriteLine(sb.ToString());
    }
}