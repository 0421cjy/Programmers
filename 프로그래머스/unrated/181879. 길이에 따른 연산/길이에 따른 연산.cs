using System;
using System.Linq;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        if (num_list.Length <= 10)
        {
            answer = 1;

            foreach(var i in num_list)
            {
                answer *= i;
            }
        }
        else
        {
            answer = num_list.Sum();
        }
        
        return answer;
    }
}