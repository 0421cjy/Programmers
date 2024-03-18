using System;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();
        var num1 = Int32.Parse(input[0]);
        var num2 = Int32.Parse(input[1]);

        var input2 = Console.ReadLine().Split();

        var indexArray = new int[num1];
        var array = new int[num1];
        var result = 0;

        for (int i = 0; i < num1; i++)
        {
            array[i] = Int32.Parse(input2[i]);
        }

        for (int i = 1; i < array.Length + 1; i++)
        {
            Combination_DFS(indexArray, array, 0, 0, i, num2, ref result);
        }

        Console.WriteLine(result);
    }

    static void Combination_DFS(int[] array, int[] newArray, int now, int pos, int r, int sum, ref int result)
    {
        if (now == r)
        {
            int total = 0;

            for (int i = 0; i < r; i++)
            {
                total += newArray[array[i]];
            }

            if (total == sum)
            {
                result++;
            }

            return;
        }

        for (int idx = pos; idx < array.Length; idx++)
        {
            array[now] = idx;
            Combination_DFS(array, newArray, now + 1, idx + 1, r, sum, ref result);
        }
    }
}