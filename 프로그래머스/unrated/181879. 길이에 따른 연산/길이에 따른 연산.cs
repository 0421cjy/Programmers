using System;
using System.Linq;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        if (num_list.Length <= 10)
        {
            answer = num_list.Aggregate((value1, value2) => value1 * value2);
        }
        else
        {
            answer = num_list.Sum();
        }
        
        return answer;
    }
}