using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int n) {
        List<int> list = new List<int>();
        int total = n;

        foreach (var d in NewPrimeGenerator(total))
        {
            while (total % d == 0)
            {
                total = total / d;
                list.Add(d);
            }

            if (total <= 1)
            {
                break;
            }
        }

        return list.Distinct().ToArray();
    }
    
    static IEnumerable<int> NewPrimeGenerator(int n)
    {
        for (int i = 2; i <= n; i++)
        {
            if (isPrime(i))
            {
                yield return i;
            }
        }
    }
    
    static bool isPrime(int n)
    {
        for (int j = 2; j * j <= n; j++)
        {
            if (n % j == 0)
            {
                return false;
            }
        }

        return true;
    }
}