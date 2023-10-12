using System;

public class Solution {
    public string solution(string bin1, string bin2) {

        var decimal1 = Convert.ToInt32(bin1, 2);
        var decimal2 = Convert.ToInt32(bin2, 2);

        var r = decimal1 + decimal2;
        
        return Convert.ToString(r, 2);
    }
}