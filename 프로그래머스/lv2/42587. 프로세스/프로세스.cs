using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] priorities, int location) {
        Queue<(int, int)> q1 = new Queue<(int, int)>();
        int index = 0;

        foreach(var i in priorities)
        {
            q1.Enqueue((index++, i));
        }
        
        int count = 0;

        while(true)
        {
            var maxValue = q1.Max(q => q.Item2);

            var queuedItem = q1.Dequeue();
            if (queuedItem.Item2 == maxValue)
            {
                count++;

                if (queuedItem.Item1 == location)
                {
                    return count;
                }
            }
            else
            {
                q1.Enqueue(queuedItem);
            }
        }
        
        return count;
    }
}