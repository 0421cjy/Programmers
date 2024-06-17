using System;
using System.Collections.Generic;

public partial class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();
        var size = Int32.Parse(input[0]);
        var count = Int32.Parse(input[1]);

        var q = new List<int>();

        var input2 = Console.ReadLine().Split();

        for (int i = 0; i < size; i++) 
        {
            q.Add(i + 1);
        }

        var windCount = 0;

        for (int i = 0;i < count; i++) 
        {
            var target = Int32.Parse(input2[i]);
            var targetIndex = q.FindIndex(x => x == target);

            if (q.Count / 2 < targetIndex)
            {
                for (int j = 0; j < q.Count; j++)
                {
                    if (target == q[0])
                    {
                        q.RemoveAt(0);
                        break;
                    }
                    else
                    {
                        WindLeft(q);
                        windCount++;
                    }
                }
            }
            else
            {
                for (int j = 0; j < q.Count; j++)
                {
                    if (target == q[0])
                    {
                        q.RemoveAt(0);
                        break;
                    }
                    else
                    {
                        WindRight(q);
                        windCount++;
                    }
                }
            }
        }

        Console.WriteLine(windCount);
    }

    static void WindLeft(List<int> q)
    {
        var target = q[q.Count - 1];
        q.Insert(0, target);
        q.RemoveAt(q.Count - 1);
    }

    static void WindRight(List<int> q)
    {
        var target = q[0];
        q.Insert(q.Count, target);
        q.RemoveAt(0);
    }
}