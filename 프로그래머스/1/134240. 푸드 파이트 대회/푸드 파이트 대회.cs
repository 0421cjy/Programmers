using System;
using System.Linq;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        
        for (int i = 1; i < food.Length; i++)
        {
            var q = food[i] / 2;
            if (q == 0)
            {
                continue;
            }

            for (int j = 0; j < q; j++)
            {
                answer += i;
            }
        }

        var reverseString = new string(answer.Reverse().ToArray());

        answer += "0" + reverseString;
        
        return answer;
    }
}