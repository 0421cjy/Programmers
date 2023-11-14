using System;
using System.Linq;

public class Solution {
    public int solution(int[] num_list) {
        var sum = num_list.Sum() * num_list.Sum();
        var multiple = 1;

        for (int i = 0; i < num_list.Length; i++)
        {
            multiple *= num_list[i];
        }

        return sum > multiple ? 1 : 0;
    }
}