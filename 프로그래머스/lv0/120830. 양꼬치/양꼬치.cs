using System;

public class Solution {
    public int solution(int n, int k) {
        
        int serviceCount = n / 10;
        int cola = k - serviceCount;

        int calc = n * 12000;
        int calc2 = cola * 2000;
        
        var r = calc + calc2;
        return r;
    }
}