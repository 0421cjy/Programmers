using System;

public class Solution {
    public int solution(int num, int n) {
        int answer = num % n;
        return answer == 0 ? 1 : 0;
    }
}