using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        var sr = new StreamReader(Console.OpenStandardInput());

        var input = sr.ReadLine();
        var num = Int32.Parse(input);

        var ints = new int[num];
        var visit = new bool[num];

        Permutation(sw, visit, ints, 0, num, num);

        sw.Close();
        sr.Close();
    }

    static void Permutation(StreamWriter sw, bool[] visit, int[] array, int depth, int n, int r)
    {
        if (depth == r)
        {
            for (int i = 0; i < r; i++)
            {
                sw.Write($"{array[i]} ");
            }

            sw.WriteLine();
            return;
        }

        for (int i = 0; i < n; i++)
        {
            if (visit[i]) continue;

            visit[i] = true;
            array[depth] = i + 1;
            Permutation(sw, visit, array, depth + 1, n, r);
            visit[i] = false;
        }
    }
}