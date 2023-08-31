using System;

class Solution
{
    public int solution(int N, int[,] road, int K)
    {
        int answer = Dijikstra(road, N, 0, K);
        return answer;
    }
    
    public int Dijikstra(int[,] array, int size, int start, int targetValue)
    {
        int[,] adj = new int[size, size];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            var x = array[i, 0];
            var y = array[i, 1];
            var v = array[i, 2];
            
            if (adj[x - 1, y - 1] != 0 && adj[x - 1, y - 1] < v) continue;

            adj[x - 1, y - 1] = v;
            adj[y - 1, x - 1] = v;
        }

        bool[] visited = new bool[size];
        int[] distance = new int[size];
        int[] parent = new int[size];
        
        Array.Fill(distance, Int32.MaxValue);

        distance[start] = 0;
        parent[start] = start;

        while (true)
        {
            int now = -1;
            int closest = Int32.MaxValue;

            for (int i = 0; i < size; i++)
            {
                if (visited[i]) continue;
                if (distance[i] == Int32.MaxValue) continue;

                if(distance[i] < closest)
                {
                    closest = distance[i];
                    now = i;
                }
            }

            if (now == -1)
            {
                break;
            }

            visited[now] = true;

            for (int next = 0; next < size; next++)
            {
                if (adj[now, next] == 0) continue;
                if (visited[next]) continue;

                int nextDist = distance[now] + adj[now, next];
                
                if (nextDist < distance[next])
                {
                    distance[next] = nextDist;
                    parent[next] = now;
                }
            }
        }

        int count = 0;

        for (int i = 0; i < distance.Length; i++)
        {
            if (distance[i] == Int32.MaxValue) continue;

            if (distance[i] <= targetValue)
            {
                count++;
            }
        }

        return count;
    }
}