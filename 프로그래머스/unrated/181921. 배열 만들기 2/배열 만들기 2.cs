using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int l, int r) {
        List<int> list = new List<int>();

        for (int i = l; i <= r; i++)
        {
            bool isValid = true;
            string s = i.ToString();

            foreach(var c in s)
            {
                if (c != '5' && c != '0')
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
            {
                list.Add(i);
            }
        }
        
        if (list.Count == 0)
        {
            list.Add(-1);
        }
        
        return list.ToArray();
    }
}