using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        List<int> odds = new List<int>();

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                continue;
            }
            else
            {
                odds.Add(i);
            }
        }

        return odds.ToArray();
    }
}