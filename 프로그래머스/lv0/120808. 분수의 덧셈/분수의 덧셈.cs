using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        
        // 최소공배수 구하기
        var newDenom = lcm(denom1, denom2);
        
        // 최소공배수로 통분하기
        numer1 *= (newDenom / denom1);
        numer2 *= (newDenom / denom2);

        int[] answer;

        // 최대공약수 구하기 (기약분수를 만들기 위해서)
        var temp = gcd(numer1 + numer2, newDenom);
        if (temp != 1) // 1이 아니면 나눠준다.
        {
            answer = new int[] { (numer1 + numer2) / temp, newDenom / temp };
            return answer;
        }

        answer = new int[] { numer1 + numer2, newDenom };
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