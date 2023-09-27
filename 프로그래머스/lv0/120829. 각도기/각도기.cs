using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int angle) {
        List<(int, int)> list = new List<(int, int)> { (0, 89), (90, 90), (91, 179), (180, 180) };

        var target = list.Select(x => x.Item1 <= angle && angle <= x.Item2);

        int count = 1;
        foreach (var i in target)
        {
            if (i) break;

            count++;
        }
        
        return count;
    }
}