using System;
using System.Collections.Generic;

public partial class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var count = Int32.Parse(input);

        var q = new Queue<int>();

        for (int i = 0;  i < count; i++) 
        {
            q.Enqueue(i + 1);
        }

        while (q.Count > 1)
        {
            q.Dequeue();
            q.Enqueue(q.Dequeue());
        }

        Console.WriteLine(q.Dequeue());
    }
}