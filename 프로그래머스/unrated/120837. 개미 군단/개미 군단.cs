using System;

public class Solution {
    public int solution(int hp) {
        const int g_ant = 5;
        const int s_ant = 3;
        const int ant = 1;
        int answer = 0;

        answer = hp / g_ant;
        var remainder = hp % g_ant;

        if (remainder == 0) return answer;

        answer += remainder / s_ant;
        remainder = remainder % s_ant;

        if (remainder == 0) return answer;

        answer += remainder / ant;
            
        return answer;
    }
}