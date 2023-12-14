using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        List<int> list = new List<int>();

        int i = 0;

        while(i < arr.Length)
        {
            if (list.Count == 0)
            {
                list.Add(arr[i]);
                i++;
                continue;
            }

            if (list.Last() < arr[i])
            {
                list.Add(arr[i]);
                i++;
                continue;
            }
            else
            {
                list.RemoveAt(list.Count - 1);
                continue;
            }
        }
        
        return list.ToArray();
    }
}