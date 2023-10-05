using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        foreach(var c in my_string.Reverse())
        {
            answer += c;
        }
        
        return answer;
    }
}