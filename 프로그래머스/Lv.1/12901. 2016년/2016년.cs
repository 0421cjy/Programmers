using System;

public class Solution {
    public string solution(int a, int b) {

        var dt = new DateTime(2016, a, b);
        string[] day = new string[] { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };

        return day[(int)dt.DayOfWeek];
    }
}