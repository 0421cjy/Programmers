using System;
using System.Collections.Generic;

public class Solution {
    public string solution(int age) {
        string answer = "";
        string ageString = age.ToString();
        
        Dictionary<int, int> d = new Dictionary<int, int>();
        int startChar = 97;

        for (int i = 0; i < 25; i++)
        {
            d.Add(i, startChar + i);
        }

        for (int i = 0; i < ageString.Length; i++)
        {
            var t = Int32.Parse(ageString[i].ToString());
            answer += Convert.ToChar(d[t]);
        }
        
        return answer;
    }
}