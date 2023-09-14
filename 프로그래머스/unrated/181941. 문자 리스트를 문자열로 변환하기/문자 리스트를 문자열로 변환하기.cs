using System;

public class Solution {
    public string solution(string[] arr) {
        
        string r = "";
        
        for (int i = 0; i < arr.Length; i++)
        {
            r += arr[i];
        }
        
        return r;
    }
}