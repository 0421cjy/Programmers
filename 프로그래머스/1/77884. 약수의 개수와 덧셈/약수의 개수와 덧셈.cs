using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int left, int right) {
        var sum = 0;

        for (var n = left; n <= right; n++)
        {
            var list = new List<int>() { 1 };

            for (var i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    if (!list.Contains(i))
                    {
                        list.Add(i);
                    }

                    if (!list.Contains(n / i))
                    {
                        list.Add(n / i);
                    }
                }
            }
            
            if (list.Count % 2 == 0)
            {
                sum += n;
            }
            else
            {
                sum -= n;
            }
        }
        
        return sum;
    }
}