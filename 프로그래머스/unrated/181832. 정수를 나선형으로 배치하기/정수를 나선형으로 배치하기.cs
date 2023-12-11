using System;

public class Solution {
    public int[,] solution(int n) {
        int[,] answer = new int[n,n];
        var count = 1;
        
        FillArray(0, 0, n, ref count, ref answer);
        
        return answer;
    }
    
    static void FillArray(int startX, int startY, int n, ref int value, ref int[,] array)
    {
        for (int i = startX; i < n; i++)
        {
            array[startX, i] = value++;
        }

        for (int i = startX + 1; i < n; i++)
        {
            array[i, n - 1] = value++;
        }

        for (int i = n - 2; startX <= i; i--)
        {
            array[n - 1 , i] = value++;
        }

        for (int i = n - 2; startX < i; i--)
        {
            array[i, startX] = value++;
        }

        if ((n - 2) + 1 >= 2)
        {
            FillArray(startX + 1, startY + 1, (n - 2) + 1, ref value, ref array);
        }
    }
}