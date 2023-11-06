using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        List<int> list = new List<int>();

        for (int i = 2; i <= n; i++)
        {
            if (IsPrime(i))
            {
                list.Add(i);
            }
        }
        
        return list.Count;
    }
    
    private static bool IsPrime(int n)
    {
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}