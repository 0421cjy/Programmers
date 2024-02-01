using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        List<int> list = new List<int>();

        for (int i = 0; i < score.Length; i++)
        {
            list.Add(score[i]);

            if (list.Count > k)
            {
                list.Remove(list.Find(x => x == list.Min()));
            }

            answer[i] = list.Min();
        }
        
        return answer;
    }
}