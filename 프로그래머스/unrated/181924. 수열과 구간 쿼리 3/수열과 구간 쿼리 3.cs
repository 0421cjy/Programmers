using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        
        var newArr = arr;
        
        for (int i = 0; i < queries.GetLength(0); i++)
        {
            var value1 = queries[i, 0];
            var value2 = queries[i, 1];

            var temp = newArr[value1];
            newArr[value1] = newArr[value2];
            newArr[value2] = temp;
        }
        
        return newArr;
    }
}