using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int number, int limit, int power) {

        var powerList = new List<int>();
        var list = new List<int>();

        for (int i = 1; i <= number; i++) 
        {
            for (int j = 1; j <= i / 2; j++)
            {
                if (i % j == 0)
                {
                    if (!list.Contains(i))
                    {
                        list.Add(i);
                    }

                    if (!list.Contains(j))
                    {
                        list.Add(j);
                    }
                }
            }

            if (list.Count == 0)
            {
                list.Add(1);
            }

            powerList.Add(list.Count);
            list.Clear();
        }

        powerList = powerList.Select(p => 
        {
            if (limit < p)
            {
                p = power;
            }

            return p;

        }).ToList();
        
        return powerList.Sum();
    }
}