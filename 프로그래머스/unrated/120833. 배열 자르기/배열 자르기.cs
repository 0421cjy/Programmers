using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers, int num1, int num2) {
        
        List<int> l = new List<int>();

        for (int i = num1; i <= num2; i++)
        {
            l.Add(numbers[i]);
        }
        
        return l.ToArray();
    }
}