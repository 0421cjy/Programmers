using System;

public class Solution {
    public int solution(int[] numbers, int n) {
        
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (n < sum)
            {
                return sum;
            }
            
            sum += numbers[i];
        }
        
        return sum;
    }
}