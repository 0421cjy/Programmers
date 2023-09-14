using System;

public class Solution {
    public int solution(int a, int b) {
        
        Int32.TryParse(a.ToString() + b.ToString(), out var r1);
        Int32.TryParse(b.ToString() + a.ToString(), out var r2);

        if (r1 > r2)
        {
            return r1;
        }
        else
        {
            return r2;
        }
        
        return r1;
    }
}