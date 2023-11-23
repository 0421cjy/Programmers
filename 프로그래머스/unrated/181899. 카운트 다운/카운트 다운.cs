using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int start, int end_num) {
        List<int> list = new List<int>();
        for (int i = end_num; i <= start; i++)
        {
            list.Add(i);
        }

        list.Sort((a, b) => b.CompareTo(a));
        
        return list.ToArray();
    }
}