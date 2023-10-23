using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;
        int r = 0;
        int count = 0;
        int newN = n;

        while(newN >= a)
        {
            count = newN / a;
            r = newN % a;
            newN = (count * b) + r;
            answer += count * b;
        }
        
        return answer;
    }
}