using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int n) {
        var list = new List<int>();
        for (int i = 1; i <= n / 2; i++)
        {
            if (list.Contains(i)) continue;

            for (int j = i; j <= n; j++)
            {
                if ((i * j) > n) break;

                if ((i * j) % n == 0)
                {
                    if (i == j)
                    {
                        list.Add(i);
                    }
                    else
                    {
                        list.Add(i);
                        list.Add(j);
                    }
                    
                    break;
                }
            }
        }
        
        if (list.Count == 0)
        {
            list.Add(n);
        }
        
        return list.Sum();
    }
}