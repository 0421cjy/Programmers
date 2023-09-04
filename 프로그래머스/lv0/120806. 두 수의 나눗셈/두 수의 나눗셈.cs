using System;

public class Solution {
    public int solution(int num1, int num2) {
        var value1 = (float)num1 / (float)num2;
        int answer = (int)(value1 * 1000);
        return answer;
    }
}