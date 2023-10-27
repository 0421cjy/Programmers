using System;
using System.Linq;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        
        for (int i = 1; i < food.Length; i++)
        {
            var q = food[i] / 2;
            if (q == 0) continue;

            for (int j = 0; j < q; j++)
            {
                answer += i;
            }
        }

        answer += "0" + string.Join("", answer.Reverse());
        
        return answer;
    }
}