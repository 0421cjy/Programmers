using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        List<int> list = new List<int>();

        int startNum = 3;
        bool flag = true;

        list.Add(2);

        while (startNum <= n)
        {
            var root = Math.Sqrt(startNum);
            flag = true;

            foreach (var i in list)
            {
                if (root < i) break;

                if (startNum % i == 0)
                {
                    flag = false;
                    break;
                }
            }

            if (flag)
            {
                list.Add(startNum);
            }

            startNum += 2;
        }
        
        return list.Count;
    }
}