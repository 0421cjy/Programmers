using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n, int[,] computers) {
        bool[] found = new bool[n];
        int answer = 0;
        for (int i = 0; i < n; i++)
        {
            answer += BFS(computers, found, n, i);
        }
        
        return answer;
    }
    
    public int BFS(int[,] network, bool[] found, int n, int start)
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(start);

        if (found[start]) return 0;
        found[start] = true;

        while(queue.Count > 0)
        {
            int now = queue.Dequeue();

            for(int next = 0; next < n; next++)
            {
                if (network[now, next] == 0) continue;
                if (found[next]) continue;

                queue.Enqueue(next);
                found[next] = true;
            }
        }

        return 1;
    }
}