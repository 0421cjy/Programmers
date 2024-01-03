using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        List<int> ints = new List<int>();
        
        while (n != 1)
        {
            ints.Add(n);

            if (n % 2 == 0)
            {
                n /= 2;
            }
            else
            {
                n = 3 * n + 1;
            }
        }

        ints.Add(n);
        
        return ints.ToArray();
    }
}