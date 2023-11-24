using System;
using System.Linq;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        var s = n.ToString().ToArray();

        for (int i = 0; i < s.Length; i++)
        {
            answer += int.Parse(s[i].ToString());
        }
        
        return answer;
    }
}