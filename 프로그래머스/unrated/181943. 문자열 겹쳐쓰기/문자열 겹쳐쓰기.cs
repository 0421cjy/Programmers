using System;
using System.Text;

public class Solution {
    public string solution(string my_string, string overwrite_string, int s) {
        
        StringBuilder sb = new StringBuilder(my_string);
        
        var r = my_string.Substring(s, overwrite_string.Length);
        string answer = sb.Replace(r, overwrite_string, s, overwrite_string.Length).ToString();
        return answer;
    }
}