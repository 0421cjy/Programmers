using System;

public class Solution {
    public int solution(int slice, int n) {
        
        int answer = 1;
        int total = slice;
        
        while(true)
        {
            if (total >= n)
            {
                break;
            }

            total += slice;
            answer++;
        }
        
        return answer;
    }
}