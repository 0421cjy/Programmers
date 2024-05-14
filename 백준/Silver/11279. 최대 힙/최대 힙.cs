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

        var q = new PriorityQueue<int, int>(new MyComparer());

        for (int i = 0; i < count; i++)
        {
            var n = Int32.Parse(sr.ReadLine());
            if (n == 0)
            {
                if (q.Count == 0)
                {
                    sb.AppendLine("0");
                }
                else
                {
                    var result = q.Dequeue();
                    sb.AppendLine(result.ToString());
                }
            }
            else
            {
                q.Enqueue(n, n);
            }
        }

        sw.WriteLine(sb.ToString());
        sw.Close();
        sr.Close();
    }

    public class MyComparer : IComparer<int>
    {
        public int Compare(int x, int y) 
        {
            return y.CompareTo(x);
        }
    }
}