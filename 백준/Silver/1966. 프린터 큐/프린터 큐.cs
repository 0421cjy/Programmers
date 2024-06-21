using System;
using System.Collections.Generic;
using System.Linq;

public partial class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var count = Int32.Parse(input);

        for (int i = 0; i < count; i++)
        {
            var input2 = Console.ReadLine().Split();
            var targetIndex = Int32.Parse(input2[1]);

            var items = Console.ReadLine().Split();

            var q = new Queue<(int, int)>();

            for (int j = 0; j < items.Length; j++) 
            {
                q.Enqueue((j,Int32.Parse(items[j])));
            }

            var count1 = 0;

            while(0 < q.Count)
            {
                var maxPriority = q.Max(q => q.Item2);
                var item = q.Dequeue();

                if (maxPriority == item.Item2)
                {
                    count1++;

                    if (targetIndex == item.Item1)
                    {
                        break;
                    }

                    continue;
                }

                q.Enqueue(item);
            }

            Console.WriteLine(count1);
        }
    }
}