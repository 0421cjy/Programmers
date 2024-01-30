using System;

public class Solution {
    public long solution(int a, int b) {
        if (a == b)
        {
            return a;
        }

        var min = Math.Min(a, b);
        var max = Math.Max(a, b);

        long answer = 0;

        for (int i = min; i <= max; i++)
        {
            answer += i;
        }
        
        return answer;
    }
}