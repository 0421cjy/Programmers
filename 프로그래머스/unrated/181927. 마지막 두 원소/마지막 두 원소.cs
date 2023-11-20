using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list) {
        var list = num_list.ToList();
        if (num_list.Last() > num_list[num_list.Length - 2])
        {
            list.Add(num_list.Last() - num_list[num_list.Length - 2]);
        }
        else
        {
            list.Add(num_list.Last() * 2);
        }
        
        return list.ToArray();
    }
}