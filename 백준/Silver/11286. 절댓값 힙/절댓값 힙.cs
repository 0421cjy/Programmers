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

        var heap = new PriorityQueue<int, int>(new NewComparerer());

        for (int i = 0; i < count; i++) 
        {
            var n = Int32.Parse(sr.ReadLine());
            if (n == 0)
            {
                if (heap.Count <= 0)
                {
                    sw.WriteLine("0");
                    continue;
                }

                sw.WriteLine(heap.Dequeue());
            }
            else
            {
                heap.Enqueue(n, n);
            }
        }

        sw.Close();
        sr.Close();
    }

    class NewComparerer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (Math.Abs(x) > Math.Abs(y) && x < y)
            {
                return y.CompareTo(x);
            }

            if (Math.Abs(x) < Math.Abs(y) && x > y)
            {
                return y.CompareTo(x);
            }

            return x.CompareTo(y);
        }
    }
}