using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
        StreamReader reader = new StreamReader(Console.OpenStandardInput());

        var input = reader.ReadLine().Split();
        var value1 = Int32.Parse(input[0]);
        var value2 = Int32.Parse(input[1]);

        var ints = Enumerable.Range(0, value1).ToArray();
        var bools = Enumerable.Repeat(false, value1).ToArray();

        NewPermutation(writer, ints, bools, 0, value1, value2);

        writer.Close();
        reader.Close();
    }

    static void NewPermutation(StreamWriter writer, int[] array, bool[] visit, int depth, int n, int r)
    {
        if (depth == r)
        {
            for (int i = 0; i < r; i++)
            {
                writer.Write($"{array[i]} ");
            }

            writer.WriteLine();
        }

        for (int i = 0; i < n; i++)
        {
            if (visit[i]) continue;

            visit[i] = true;
            array[depth] = i + 1;
            NewPermutation(writer, array, visit, depth + 1, n, r);
            visit[i] = false;
        }
    }
}
