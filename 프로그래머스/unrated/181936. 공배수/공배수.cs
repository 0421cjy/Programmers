using System;

public class Solution {
    public int solution(int number, int n, int m) {
        int answer = 0;
        
        var r1 = number % n;
        var r2 = number % m;
        
        if (r1 + r2 == 0)
        {
            answer = 1;
        }
        
        return answer;
    }
}