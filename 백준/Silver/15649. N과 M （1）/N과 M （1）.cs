using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
        StreamReader reader = new StreamReader(Console.OpenStandardInput());

        string[] input = reader.ReadLine().Split();
        int N = int.Parse(input[0]);
        int M = int.Parse(input[1]);

        int[] result = new int[9];
        bool[] visited = new bool[9];

        DFS(0);

        writer.Close();
        reader.Close();

        void DFS(int count)
        {
            if (count == M)
            {
                for (int i = 0; i < M; i++)
                    writer.Write($"{result[i]} ");
                writer.WriteLine();
            }
            else
            {
                for (int i = 1; i <= N; i++)
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        result[count] = i;
                        DFS(count + 1);
                        visited[i] = false;
                    }
                }
            }
        }
    }
}