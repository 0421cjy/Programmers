using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int number, int limit, int power) {

        var powerList = new List<int>();

        for (int i = 1; i <= number; i++) 
        {
            var count = 0;

            for (int j = 1; j * j <= i; j++)
            {
                if (j * j == i)
                {
                    count++;
                }
                else if (i % j == 0)
                {
                    count += 2;
                }
            }

            powerList.Add(count);
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