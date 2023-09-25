using System;

public class Solution {
    public int solution(int n) {
        int count = 0;

        while(0 < n)
        {
            n = n - 7;
            count++;
        }
        
        return count;
    }
}