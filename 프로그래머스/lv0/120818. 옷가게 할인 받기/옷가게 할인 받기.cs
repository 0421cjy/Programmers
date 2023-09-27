using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int price) {
        
        List<(int, double)> list = new List<(int, double)> ();
        list.Add((0, 0));
        list.Add((100000, 5));
        list.Add((300000, 10));
        list.Add((500000, 20));

        var count = list.Select(x => x.Item1 <= price).Count(y => y == true);
        var target = list[count - 1];

        return (int)(price - (price * (target.Item2 / 100)));
    }
}