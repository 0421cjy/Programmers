using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        Queue<string> q1 = new Queue<string>();
        Queue<string> q2 = new Queue<string>();

        foreach(var item in cards1)
        {
            q1.Enqueue(item);
        }

        foreach (var item in cards2)
        {
            q2.Enqueue(item);
        }

        for (int i = 0; i< goal.Length; i++)
        {
            if (0 < q1.Count)
            {
                var r = q1.Peek();
                if (r == goal[i])
                {
                    q1.Dequeue();
                    continue;
                }
            }

            if (0 < q2.Count)
            {
                var r1 = q2.Peek();
                if (r1 == goal[i])
                {
                    q2.Dequeue();
                    continue;
                }
            }

            return "No";
        }
        
        return "Yes";
    }
}