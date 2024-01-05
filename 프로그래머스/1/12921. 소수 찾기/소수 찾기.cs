using System;

public class Solution {
    public int solution(int n) 
    {
        int answer = 0;
        
        for (int i = 2; i <= n; i++)
        {
            if (IsPrime(i))
            {
                answer++;
            }
        }
        
        return answer;
    }
    
    public bool IsPrime(int n)
    {
        for (int i = 2; i * i <= n; i++)
        {
            if (i == n) continue;
            
            if (n % i == 0)
            {
                return false;
            }
        }
        
        return true;
    }
}