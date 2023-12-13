using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] answers) {
        int[] list1 = new int[] { 1, 2, 3, 4, 5 };
        int[] list2 = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] list3 = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

        Dictionary<int, int> dic = new Dictionary<int, int>();
        dic.Add(1, 0);
        dic.Add(2, 0);
        dic.Add(3, 0);

        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == list1[i % list1.Length])
            {
                dic[1]++;
            }
        }

        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == list2[i % list2.Length])
            {
                dic[2]++;
            }
        }

        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == list3[i % list3.Length])
            {
                dic[3]++;
            }
        }

        var maxValue = dic.Max(x => x.Value);
        var list = new List<int>();

        foreach(var i in dic)
        {
            if (i.Value == maxValue)
            {
                list.Add(i.Key);
            }
        }
        
        return list.ToArray();
    }
}