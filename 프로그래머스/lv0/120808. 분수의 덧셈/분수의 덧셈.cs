using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        
        var temp = lcm(denom1, denom2);
        numer1 *= (temp / denom1);
        numer2 *= (temp / denom2);

        int[] answer;

        var temp2 = gcd(numer1 + numer2, temp);
        if (temp2 != 1)
        {
            answer = new int[] { (numer1 + numer2) / temp2, temp / temp2 };
            return answer;
        }

        answer = new int[] { numer1 + numer2, temp };
        return answer;
    }
    
    public int gcd(int a, int b)
    {
        while(b > 0)
        {
            int c = a % b;
            a = b;
            b = c;
        }
        
        return a;
    }
    
    public int lcm(int a, int b)
    {
        return (a * b) / gcd(a, b);
    }
}