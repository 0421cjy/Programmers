using System;
using System.Collections.Generic;
using System.IO;

public partial class Program
{
    static void Main(string[] args)
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        var sr = new StreamReader(Console.OpenStandardInput());

        var input = sr.ReadLine();
        var count = Int32.Parse(input);

        var q = new PriorityQueue<int, int>();

        for (int i = 0; i < count; i++) 
        {
            var num = Int32.Parse(sr.ReadLine());
            if (num == 0) 
            {
                if (q.Count == 0)
                {
                    sw.WriteLine("0");
                }
                else
                {
                    sw.WriteLine(q.Dequeue());
                }
            }
            else
            {
                q.Enqueue(num, num);
            }
        }

        sw.Close();
        sr.Close();
    }
}