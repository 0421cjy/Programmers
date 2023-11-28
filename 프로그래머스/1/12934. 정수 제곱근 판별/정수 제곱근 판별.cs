using System;

public class Solution {
    public long solution(long n) {
        var r = Math.Sqrt(n);
        return (n % r == 0) ? (long)Math.Pow(r + 1, 2) : -1;
    }
}