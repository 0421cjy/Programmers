using System;

public class Solution {
    public string solution(string my_string, int k) {
        
        string result = "";
        for (int i = 0; i < k; i++)
        {
            result += my_string;
        }
        
        return result;
    }
}