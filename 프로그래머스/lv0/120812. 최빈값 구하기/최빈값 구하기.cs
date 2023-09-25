using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] array) {
        var maxNum = array.Max();

        List<int> list = new List<int>();

        for (int i = 0; i <= maxNum; i++)
        {
            int r = array.Count(x => x == i);
            list.Add(r);
        }

        var maxValue = list.Max();
        var temp = list.Count(x => x == maxValue);
        if (1 < temp)
        {
            return -1;
        }
        
        var index = list.FindIndex(x => x == maxValue);
        return index;
    }
}