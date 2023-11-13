using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int k, int m, int[] score) {
        var list = score.OrderByDescending(x => x).ToList();
        var newList = list.GetRange(0, m * (list.Count() / m));
        var boxList = new List<int>();
        var answer = 0;

        foreach(var item in newList)
        {
            boxList.Add(item);

            if (boxList.Count() == m)
            {
                var min = boxList.Min();
                answer += min * boxList.Count();

                boxList.Clear();
            }
        }
        
        return answer;
    }
}