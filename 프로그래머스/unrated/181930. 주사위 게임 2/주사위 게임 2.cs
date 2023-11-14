using System;

public class Solution {
    public int solution(int a, int b, int c) {
        int count = 0;
        if (a.Equals(b)) count++;
        if (a.Equals(c)) count++;
        if (b.Equals(c)) count++;

        if (count == 0)
        {
            return (a + b + c);
        }

        if (count == 1)
        {
            return (a + b + c) * ((int)Math.Pow(a, 2) + (int)Math.Pow(b, 2) + (int)Math.Pow(c, 2));
        }

        return (a + b + c) * 
            ((int)Math.Pow(a, 2) + (int)Math.Pow(b, 2) + (int)Math.Pow(c, 2)) *
            ((int)Math.Pow(a, 3) + (int)Math.Pow(b, 3) + (int)Math.Pow(c, 3));
    }
}