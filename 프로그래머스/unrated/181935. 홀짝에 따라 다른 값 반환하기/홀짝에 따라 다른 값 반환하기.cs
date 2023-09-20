using System;

public class Solution {
    public int solution(int n) 
    {
        int answer = 0;
        
        if (IsOdd(n))
        {
            for (int i = n; 0 < i; i--)
            {
                if (IsOdd(i))
                {
                    answer += i * i;
                }
            }
        }
        else
        {
            for (int i = n; 0 < i; i--)
            {
                if (!IsOdd(i))
                {
                    answer += i;
                }
            }
        }
        
        
        return answer;
    }

    public bool IsOdd(int n)
    {
        if (n % 2 == 0)
        {
            return true;
        }
    
        return false;
    }
}