using System;

public class Solution {
    public int solution(int n) {
        var r = lcm(n, 6);
        var answer = r / 6;
        
        return answer;
    }
    
    int gcd(int a, int b)
    {
        while(b > 0)
        {
            var c = a % b;
            a = b;
            b = c;
        }

        return a;
    }

    int lcm(int n, int m)
    {
        return (n * m) / gcd(n, m);
    }
}