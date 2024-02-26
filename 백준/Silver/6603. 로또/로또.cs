using System;
using System.Collections.Generic;

public class Combination
{
    private readonly int r = 6;
    private List<int> list = new List<int>();
    private int[] arr;

    public Combination(int[] arr)
    {
        this.arr = arr;

        for (int i = 0; i < r; i++) 
        {
            list.Add(0);
        }
    }

    public void DoCombination(int now, int pos)
    {
        if (now == r)
        {
            for (int i = 0; i < r; i++)
            {
                Console.Write(arr[list[i]] + " ");
            }

            Console.WriteLine();
            return;
        }

        for (int idx = pos; idx < arr.Length; idx++)
        {
            list[now] = idx;
            DoCombination(now + 1, idx + 1);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            List<int> list = new List<int>();

            var input = Console.ReadLine().Split();
            if (input[0] == "0") break;

            for (int i = 1; i < input.Length; i++)
            {
                var n = Int32.Parse(input[i]);
                list.Add(n);
            }

            Combination c = new Combination(list.ToArray());
            c.DoCombination(0, 0);
            Console.WriteLine();
        }
    }
}