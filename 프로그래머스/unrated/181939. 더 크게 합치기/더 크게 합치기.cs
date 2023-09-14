using System;

public class Solution {
    public int solution(int a, int b) {
        
        int num1 = Int32.Parse($"{a}{b}");
        int num2 = Int32.Parse($"{b}{a}");
        
        return Math.Max(num1, num2);
    }
}