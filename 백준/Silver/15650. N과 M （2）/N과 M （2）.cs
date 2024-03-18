using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        var sr = new StreamReader(Console.OpenStandardInput());

        var input = sr.ReadLine().Split();
        var num1 = Int32.Parse(input[0]);
        var num2 = Int32.Parse(input[1]);

        var ints = Enumerable.Repeat(0, num1).ToArray();

        Combination_DFS(sw, ints, 0, 0, num2);

        sw.Close();
        sr.Close();
    }

    static void Combination_DFS(StreamWriter sw, int[] array, int now, int pos, int r)
    {
        if (now == r)
        {
            for (int i = 0; i < r; i++)
            {
               sw.Write($"{array[i]} ");
            }

            sw.WriteLine();
            return;
        }

        for (int idx = pos; idx < array.Length; idx++)
        {
            array[now] = idx + 1;
            Combination_DFS(sw, array, now + 1, idx + 1, r);
        }
    }
}