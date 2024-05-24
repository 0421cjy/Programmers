using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public partial class Program
{
    static void Main(string[] args)
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        var sr = new StreamReader(Console.OpenStandardInput());

        var sb = new StringBuilder();

        var input = sr.ReadLine();
        var count = Int32.Parse(input);

        var stack = new Stack<int>();
        var number = 1;

        for (int i = 0; i < count; i++) 
        {
            var n = Int32.Parse(sr.ReadLine());

            if (stack.Contains(n))
            {
                while (stack.Contains(n)) 
                {
                    stack.Pop();
                    sb.AppendLine("-");
                }
            }
            else
            {
                while(!stack.Contains(n)) 
                {
                    if (stack.Count > 0 && stack.Peek() > n)
                    {
                        sb.Clear();
                        sw.WriteLine("NO");

                        sw.WriteLine(sb.ToString());
                        sw.Close();
                        sr.Close();
                        return;
                    }

                    stack.Push(number++);
                    sb.AppendLine("+");
                }

                stack.Pop();
                sb.AppendLine("-");
            }
        }

        sw.WriteLine(sb.ToString());
        sw.Close();
        sr.Close();
    }
}