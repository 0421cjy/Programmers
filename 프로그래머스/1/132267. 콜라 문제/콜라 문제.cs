using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;
        int r = 0;
        int count = 0;

        while(n >= a)
        {
            count = n / a;
            r = n % a;
            n = (count * b) + r;
            answer += count * b;
        }
        
        return answer;
    }
}