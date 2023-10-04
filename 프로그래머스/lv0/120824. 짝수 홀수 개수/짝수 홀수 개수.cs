using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int count = 0;
        foreach(var num in num_list)
        {
            if (num % 2 == 0)
            {
                count++;
            }
        }

        var r = num_list.Length - count;
        
        int[] resultArray = {count, r};
        return resultArray;
    }
}