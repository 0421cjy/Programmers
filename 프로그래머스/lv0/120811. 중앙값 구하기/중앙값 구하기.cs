using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] array) {
        
        List<int> ints = new List<int>();

        for (int i = 0; i < array.Length; i++)
        {
            ints.Add(array[i]);
        }

        ints.Sort();

        return ints[ints.Count / 2];
    }
}