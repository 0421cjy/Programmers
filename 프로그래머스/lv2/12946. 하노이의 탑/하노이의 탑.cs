using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[,] solution(int n)
    {
        List<(int, int)> list = new List<(int, int)>();
        hanoiTower(n, 1, 3, 2, list);

        int[,] newArray = new int[list.Count, 2];

        for (int i = 0; i < list.Count; i++)
        {
            newArray[i, 0] = list[i].Item1;
            newArray[i, 1] = list[i].Item2;
        }

        return newArray;
    }

    public void hanoiTower(int n, int start, int target, int middle, List<(int, int)> answer)
    {
        if (n == 1)
        {
            answer.Add((start, target));
            return;
        }

        hanoiTower(n - 1, start, middle, target, answer);
        answer.Add((start, target));
        hanoiTower(n - 1, middle, target, start, answer);
    }
}